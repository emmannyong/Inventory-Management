using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BugTrack
{
    public partial class members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "bugrack");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Select * From users;", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        LiteralText.Text += "<div align='center' class='thumbnail col-sm-3'><img src='Content/user.png' alt='User'><div class='caption'>";
                        while (reader.Read())
                        {
                            LiteralText.Text += string.Format("<h5>{0}</h5><p>{1}<p><p> Role: {2}<p><p> Joined: {3}<p></div></div>",
                                HttpUtility.HtmlEncode(reader.GetString(1)),
                                HttpUtility.HtmlEncode(reader.GetString(3)),
                                HttpUtility.HtmlEncode(reader.GetString(5)),
                                HttpUtility.HtmlEncode(reader.GetString(6))

                                );
                            //LiteralText.Text += "<td><a class='btn btn-sm btn-primary' href='projbugs.aspx?item=" + reader.GetString(1) + "'>Bugs</a></td></ tr >";
                        }
                        //LiteralText.Text += "</table>";
                    }
                }
            }
        }
    }
}