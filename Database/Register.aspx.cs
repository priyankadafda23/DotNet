using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\priya\\Desktop\\RKU\\Sem5\\DotNet\\Database\\App_Data\\Database1.mdf;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);

            //con.Open();
            //String query = "insert into Register1 Values('" + idtxt.Text + "','" + nametxt.Text + "','" + passwordtxt.Text + "','" + emailtxt.Text + "','" + contactnotxt.Text + "')";
            //SqlCommand cmd = new SqlCommand(query, con);

            //cmd.ExecuteNonQuery();
            ////Response.Write("Inserted successfully");
            //Response.Write("<script>alert('Data inserted successfully');</script>");

            //con.Close();

            //second method using parameterized query to prevent SQL injection
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\priya\\Desktop\\RKU\\Sem5\\DotNet\\Database\\App_Data\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "INSERT INTO Register1 VALUES (@Id, @Name, @Password, @Email, @ContactNo)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", idtxt.Text);
            cmd.Parameters.AddWithValue("@Name", nametxt.Text);
            cmd.Parameters.AddWithValue("@Password", passwordtxt.Text);
            cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
            cmd.Parameters.AddWithValue("@ContactNo", contactnotxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Data inserted successfully');</script>");
            
        }
    }
}