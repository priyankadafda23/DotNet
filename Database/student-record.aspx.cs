using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\priya\\Desktop\\RKU\\Sem5\\DotNet\\Database\\App_Data\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "INSERT INTO StudentRecord VALUES (@Name, @Branch, @Sem, @City, @Gender)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", namet.Text);
            cmd.Parameters.AddWithValue("@Branch", brancht.Text);
            cmd.Parameters.AddWithValue("@Sem", semt.Text);
            cmd.Parameters.AddWithValue("@City", cityt.Text);
            cmd.Parameters.AddWithValue("@Gender", gendert.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Data inserted successfully');</script>");
        }
    }
}