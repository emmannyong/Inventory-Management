using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace InventoryMgt
{
    public partial class stores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "medstore");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Select * From store;", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        LiteralText.Text += "<table class='table table-hover'><tr><th>ID</th><th>Name</th><th>Created</th><th>Action</th></tr>";
                        while (reader.Read())
                        {
                            LiteralText.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td>",
                                HttpUtility.HtmlEncode(reader.GetString(0)),
                                HttpUtility.HtmlEncode(reader.GetString(1)),
                                HttpUtility.HtmlEncode(reader.GetString(2))
                                );
                            LiteralText.Text += "<td><a class='btn btn-sm btn-primary' href='stocks.aspx?item=" + reader.GetString(1) + "'>Stock</a></td></ tr >";
                        }
                        LiteralText.Text += "</table>";
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pname = "";
            pname = PrNam.Text;
            
            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "medstore");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Insert Into store (pname) " +
                    "Values (?D);", connection);
                command.Parameters.AddWithValue("?D", pname);
               
                if (command.ExecuteNonQuery() > 0)
                {
                    LiteralMsg.Text += "<div class='alert alert-success'> Success! " +
                        "Bug Added Successfully.</ div > ";
                }
                else
                {
                    LiteralMsg.Text += "<div class='alert alert-danger'> Error! " +
                        "Failed To Add Bug. Please Try Again.</ div > ";
                }
            }
        }
    }
}