using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace web
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void log(object sender, EventArgs e)
        {
            string formuname = uname.Text;
            string formpass  = pass.Text;
            try
            {
                string cs = "Data Source=DESKTOP-RDKB9SN\\SQLEXPRESS;Initial Catalog=db_nccs;Integrated Security=true;";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                string fetchQuery = "select * from tbl_reg where username=@username and password=@password";
                SqlCommand sc = new SqlCommand(fetchQuery, conn);
                sc.Parameters.AddWithValue("@username", formuname);
                sc.Parameters.AddWithValue("@password", formpass);
                SqlDataReader row = sc.ExecuteReader();
               
                if(row.Read()) 
                {
                    l3.Text = "welcome";
                }
                else
                {
                    l3.Text = "username or password incorrect";
                }
            }
            catch (SqlException s) 
            {
                Console.WriteLine(s);
            }
        }
    }
}