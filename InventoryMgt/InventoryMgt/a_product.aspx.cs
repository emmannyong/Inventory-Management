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
            if (!IsPostBack)
            { 
                string prod = Request.QueryString["item"];
                //string str = Request.QueryString["store"];

                string Pid = "", Pname = "", stor = "", stoc = "", cp = "", sp = "", expd = "";
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
                                stor = reader.GetString(2);
                                stoc = reader.GetString(3);
                                cp = reader.GetString(4);
                                sp = reader.GetString(5);
                                expd = reader.GetString(7);
                            }
                        }
                    }
                }

                pid.Text = Pid;
                pname.Text = Pname;
                stock.Text = stoc;
                store.Items.Add(stor);
                cost.Text = cp;
                //sale.Text = sp;
                exp.Text = expd;

            }       
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string xpid = "", pnam = "", stor = "", stoc = "", cp = "", sp = "", xpir = "";
            xpid = pid.Text;
            pnam = pname.Text;
            stor = store.Text;
            stoc = stock.Text;
            cp = cost.Text;
            sp = sale.Text;
            xpir = exp.Text;

            //string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                //"localhost", "root", "", "medstore");
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE stock SET product=?D, store=?P, stock=?E, cprice=?S, sprice=?C, expiry=?M " +
                    "WHERE `id`=?Q;", connection);
                command.Parameters.AddWithValue("?D", pnam);
                command.Parameters.AddWithValue("?P", stor);
                command.Parameters.AddWithValue("?E", stoc);
                command.Parameters.AddWithValue("?S", cp);
                command.Parameters.AddWithValue("?C", sp);
                command.Parameters.AddWithValue("?M", xpir);
                command.Parameters.AddWithValue("?Q", xpid);

                if (command.ExecuteNonQuery() > 0)
                {
                    LiteralMsg.Text += "<div class='alert alert-success'> Success! " +
                        "Stock Product Added Successfully.</ div > ";
                }
                else
                {
                    LiteralMsg.Text += "<div class='alert alert-danger'> Error! " +
                        "Failed To Add Stock Product. Please Try Again.</ div > ";
                }
            }
        }
    }
}