using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PatientApp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["q"] != null && Request.QueryString["q"] == "logout")
            {
                Session.Abandon();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lun = "", lpw = "", lrl = "";
            string un = user.Text;
            string pw = pass.Text;

            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "patient_apt");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Select * From users WHERE username='" + un + "' AND password='" + pw + "';", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lun = reader.GetString(3);
                            lpw = reader.GetString(4);
                            lrl = reader.GetString(5);
                        }
                        if (pw == lpw && un == lun)
                        {
                            LiteralText.Text += "<div class='alert alert-success'> Success! " +
                                "Login Successful.</ div > ";
                            Session.Add("username", un);
                            Session.Add("password", pw);
                            Response.Redirect("/"+lrl+".aspx");
                        }
                        else
                        {
                            LiteralText.Text += "<div class='alert alert-danger'> Error! " +
                                "Wrong Username Or Password.</ div > ";
                        }

                    }
                    else
                    {
                        LiteralText.Text += "<div class='alert alert-danger'> Error! " +
                            "Username Entered Does Not Exist.</ div > ";
                    }
                }
            }

        }
    }
}