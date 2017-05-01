using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace InventoryMgt
{
    public partial class product1 : System.Web.UI.Page
    {
        string connectionInfo = string.Format("server={0};user id={1};password={2};database={3};charset=utf8;",
                "localhost", "root", "", "medstore");
        protected void Page_Load(object sender, EventArgs e)
        {
            string prod = Request.QueryString["item"];
            string str = Request.QueryString["store"];

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

            rspid.Text = Pid;
            rspn.Text = Pname;
            rsst.Text = stoc;

            LiteralInfo.Text = "<p class='col-md-6'>Name:  " + Pname 
                + "</p><p class='col-md-6'>Current Stock:  " + stoc
                + "</p><p class='col-md-6'>Cost Price:  " + cp
                + "</p><p class='col-md-6'>Sale Price:  " + sp
                + "</p><p class='col-md-6'>Expiry Date:  " + expd
                + "</p><p class='col-md-12 text-center'>From The Store:  " + stor + "</p>"
                + "<br><a class='col-md-12 btn btn-success btn-md' target='_blank' href='a_product.aspx?item=" + Pid + "'> Update Informstion</a><br />";

            LiteralGo.Text = "<a class='btn btn-info btn-md' target='_blank' href='stocks.aspx?item=" + stor + "'> Back To Store</a><br />"
                + "<p>At >> " + stor + "</p>";
        }
        
        
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string pid = "", pn = "", newst = "", st = "", action = "";
            int tot = 200;
            pid = rspid.Text;
            pn = rspn.Text;
            newst = newSt.Text;
            st = rsst.Text;
            action = act.SelectedValue;
            
            
            if (action.Equals("add")) { tot = int.Parse(st) + int.Parse(newst); }
            else if (action.Equals("deduct") && int.Parse(st) >= int.Parse(newst)) { tot = int.Parse(st) - int.Parse(newst); }
            else { tot = int.Parse(st); }
            
            LiteralMsg.Text += tot.ToString();
            using (var connection = new MySqlConnection(connectionInfo))
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE stock SET stock=?U " +
                    "WHERE `id`=?D;", connection);
                command.Parameters.AddWithValue("?U", tot.ToString());
                command.Parameters.AddWithValue("?D", pid);
                
                if (command.ExecuteNonQuery() > 0 )
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