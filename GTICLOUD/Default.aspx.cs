using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace GTICLOUD
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string query = "select email,password from registration;";

            

                SqlCommand cmd = DB.ExecuteReader(query);

                SqlDataReader dbr = cmd.ExecuteReader();

                if (!dbr.HasRows)
                {

                    Response.Write("<script>alert('No Data availabe');</script>");
                }
                else
                {

                    while (dbr.Read())
                    {

                        if (dbr["email"].Equals(email.Text) && dbr["password"].Equals(password.Text))
                        {

                            Response.Redirect("Dashboard.aspx");
                        }
                        else
                        {

                            Response.Write("<script>alert('Email or Password is incorrent');</script>");
                            break;
                        }
                    }
                }

                cmd.Dispose();
                dbr.Dispose();
                DB.CloseConn();


            
        }



    }
}