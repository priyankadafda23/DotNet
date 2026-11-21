
using System;
using System.Data.SqlClient;

namespace HDFC_Loans
{
    public partial class Login : System.Web.UI.Page
    {
        string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\priya\\Desktop\\RKU\\Sem5\\DotNet\\HDFC_Loans\\App_Data\\HDFC_Loans.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM Users
                                 WHERE UserEmail=@email
                                 AND Password=@password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                con.Open();

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result > 0)
                {
                    Session["UserEmail"] = txtEmail.Text;

                    Response.Redirect("~/Home.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid Email or Password";
                    lblMessage.ForeColor =
                        System.Drawing.Color.Red;
                }
            }
        }
    }
}
