using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace InventoryMgt
{
    public partial class product : System.Web.UI.Page
    {
        string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "medstore");
        protected void Page_Load(object sender, EventArgs e)
        {
            string prod = Request.QueryString["item"];
            string str = Request.QueryString["store"];

            string Pid = "", Pname = "", stor = "", stoc = "", cp = "", sp = "", expd = "", em = "";
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Select * From stock WHERE `id`=" + prod + ";", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Pid = reader.GetString(0);
                            Pname = reader.GetString(1);
                            stor = reader.GetString(3);
                            stoc = reader.GetString(7);
                            cp = reader.GetString(4);
                            sp = reader.GetString(5);
                            expd = reader.GetString(6);
                        }
                    }
                }
            }

            pid.Text = Pid;
            rspid.Text = Pid;
            pname.Text = Pname;
            rspn.Text = Pname;
            stock.Text = stoc;
            rsst.Text = stoc;
            store.Items.Add(stor);
            cost.Text = cp;
            sale.Text = sp;
            exp.Text = expd;

                   
        }
        /**
        public void getHistory(string x)
        {
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Select * From history WHERE `bug`='" + x + "';", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        LiteralHist.Text += "<table class='table table-hover'>"
                            + "<tr><th>ID</th><th>User</th><th>Bug</th><th>Track</th><th>Error</th><th>Status</th><th>Date</th></tr>";
                        while (reader.Read())
                        {
                            LiteralHist.Text += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td>><td>{5}</td><td>{6}</td>",
                                HttpUtility.HtmlEncode(reader.GetString(0)),
                                HttpUtility.HtmlEncode(reader.GetString(1)),
                                HttpUtility.HtmlEncode(reader.GetString(2)),
                                HttpUtility.HtmlEncode(reader.GetString(3)),
                                HttpUtility.HtmlEncode(reader.GetString(4)),
                                HttpUtility.HtmlEncode(reader.GetString(5)),
                                reader.GetString(6)
                                );
                        }
                        LiteralHist.Text += "</table>";
                    }
                }
            }
        }*/
        public String getPRBase(string x)
        {
            string pbase = "";
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Select psrc From projects WHERE pname='"+x+"';", connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            pbase = reader.GetString(0);
                        }
                    }
                    return pbase;
                }
            }
        }
        protected void reStock_Click(object sender, EventArgs e)
        {
        }
        protected void deStock_Click(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string bid = "", err = "", newst = "", trno = "", user = "";
           // bid = bugId.Text;
            //err = errm.Text;
            //newst = newStat.Text;
            //trno = trNo.Text;
            //user = Session["username"].ToString();

            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("Insert Into history (user, bug, track, error, newstat) " +
                    "Values (?U, ?D, ?P, ?E, ?S);", connection);
                command.Parameters.AddWithValue("?U", user);
                command.Parameters.AddWithValue("?D", bid);
                command.Parameters.AddWithValue("?P", trno);
                command.Parameters.AddWithValue("?E", err);
                command.Parameters.AddWithValue("?S", newst);
                //Update
                var command1 = new MySqlCommand("UPDATE bugs SET status = ?N WHERE `id` = ?I;", connection);
                command1.Parameters.AddWithValue("?N", newst);
                command1.Parameters.AddWithValue("?I", bid);
                if (command.ExecuteNonQuery() > 0 && command1.ExecuteNonQuery() > 0)
                {
                    LiteralMsg.Text += "<div class='alert alert-success'> Success! " +
                        "Bug Updated Successfully.</ div > ";
                }
                else
                {
                    LiteralMsg.Text += "<div class='alert alert-danger'> Error! " +
                        "Failed To Update Bug. Please Try Again.</ div > ";
                }
            }
        }
    }
}