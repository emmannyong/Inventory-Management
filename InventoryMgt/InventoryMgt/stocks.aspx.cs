using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace InventoryMgt
{
    public partial class bugs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string proj = Request.QueryString["item"];
            if (proj != null)
            {
                string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                    "localhost", "root", "", "medstore");
                using (var connection = new MySqlConnection(connectionInfo))
                {
                    connection.Open();
                    var command = new MySqlCommand("Select * From store WHERE `sname`='" + proj + "';", connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                store.Items.Add(reader.GetString(1));
                            }
                        }
                    }
                }
                using (var connection = new MySqlConnection(connectionInfo))
                {
                    connection.Open();
                    var command = new MySqlCommand("Select * From stock WHERE `store`='"+proj+"';", connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            LiteralText.Text += "<table class='table table-hover'>"
                                + "<tr><th>ID</th><th>Name</th><th>Store</th><th>Stock</th><th>Cost</th><th>Sale</th>"
                                + "<th>Expiry</th><th>Added on</th><th>Action</th></tr>";
                            while (reader.Read())
                            {
                                LiteralText.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td>><td>{5}</td><td>{6}</td><td>{7}</td>",
                                    HttpUtility.HtmlEncode(reader.GetString(0)),
                                    HttpUtility.HtmlEncode(reader.GetString(1)),
                                    HttpUtility.HtmlEncode(reader.GetString(2)),
                                    HttpUtility.HtmlEncode(reader.GetString(3)),
                                    HttpUtility.HtmlEncode(reader.GetString(4)),
                                    HttpUtility.HtmlEncode(reader.GetString(5)),
                                    HttpUtility.HtmlEncode(reader.GetString(6)),
                                    HttpUtility.HtmlEncode(reader.GetString(7))
                                    );
                                LiteralText.Text += "<td><a class='btn btn-warning btn-sm' href='product.aspx?item=" + reader.GetString(0) + "&store=" + reader.GetString(2) + "'>View</a></td></ tr >";
                            }
                            LiteralText.Text += "</table>";
                        }
                    }
                }
            }
            else
            {
                Response.Redirect("/all_stock.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pnam = "", stor = "", stoc = "", cp = "", sp = "", expir = "";
            pnam = pname.Text;
            stor = store.Text;
            stoc = stock.Text;
            cp = cost.Text;
            sp = sale.Text;
            DateTime dex = DateTime.Parse(exp.Text);
            expir = dex.ToString();
            
            string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "bugrack");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Insert Into stock (product, store, stock, cprice, sprice, expiry) " +
                    "Values (?D, ?P, ?E, ?S, ?C, ?M);", connection);
                command.Parameters.AddWithValue("?D", pnam);
                command.Parameters.AddWithValue("?P", stor);
                command.Parameters.AddWithValue("?E", stoc);
                command.Parameters.AddWithValue("?S", cp);
                command.Parameters.AddWithValue("?C", sp);
                command.Parameters.AddWithValue("?M", expir);
                
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