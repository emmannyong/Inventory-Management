using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace PatientApp
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string fn = fname.Text;
            string un = username.Text;
            string em = email.Text;
            string pw = pass.Text;
            string rl = role.Text;

            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "patient_apt");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Insert Into users (fullname, email, username, password, role) Values (?FN, ?EM, ?UN, ?PASS, ?R);", connection);
                command.Parameters.AddWithValue("?FN", fn);
                command.Parameters.AddWithValue("?EM", em);
                command.Parameters.AddWithValue("?UN", un);
                command.Parameters.AddWithValue("?PASS", pw);
                command.Parameters.AddWithValue("?R", rl);
                if (command.ExecuteNonQuery() > 0)
                {
                    LiteralText.Text += "<div class='alert alert-success'> Success! " +
                        "Registeration Successful. Proceed Login with your new Username and Password.</ div > ";
                }
                else
                {
                    LiteralText.Text += "<div class='alert alert-danger'> Error! " +
                        "Registeration Failed. Please Try Again.</ div > ";
                }
            }
        }
    }
}