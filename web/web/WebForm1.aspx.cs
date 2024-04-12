using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //when submit button is clicked
        protected void btn_sub(object sender, EventArgs e)
        {
            //connecting to the database
            string cs = "Data Source=DESKTOP-RDKB9SN\\SQLEXPRESS;Initial Catalog=db_nccs;Integrated Security=true;";
            SqlConnection Conn = new SqlConnection(cs);
            //when submit is clicked control will come here
            //extracting form field
            string username = uname.Text;
            string password = pass.Text;
            string repassword = repass.Text;
            string gender = "";
            if (r1.Checked)
            {
                gender = r1.Text;
            }
            else
            {
                gender = r2.Text;
            }

            string course = "";
            if (c1.Checked)
            {
                course = course + c1.Text + " ";
            }
            if (c2.Checked)
            {
                course = course + c2.Text + " ";
            }
            if (c3.Checked)
            {
                course = course + c3.Text + " ";
            }

            string coun = "";
            if (country.SelectedValue == "")
            {
                coun = "Country not selected.";
            }
            else
            {
                coun = country.SelectedValue;
            }

            l7.Text = "Username is " + username + ". Password is " + password + ". Repassword is " + repassword +
                ". Gender is " + gender + ". Course is " + course + ". Country is " + coun + ".";
            //executing query 
            try
            {
                Conn.Open();
                string insQuery = "insert into tbl_reg values(@username, @password, @repassword, @gender, @course, @country)";
                SqlCommand sc = new SqlCommand(insQuery, Conn);
                sc.Parameters.AddWithValue("@username", username);
                sc.Parameters.AddWithValue("@password", password);
                sc.Parameters.AddWithValue("@repassword", repassword);
                sc.Parameters.AddWithValue("@gender", gender);
                sc.Parameters.AddWithValue("@course", course);
                sc.Parameters.AddWithValue("@country", coun);
                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    l7.Text = "Data inserted.";
                }
                else
                {
                    l7.Text = "Data not inserted.";
                }
            }
            catch(SqlException s) {
                Console.WriteLine(s);
            }
           
        }
    }
}
    