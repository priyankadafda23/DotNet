
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HDFC_Loans
{
    public partial class RemoveApplication : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\priya\\Desktop\\RKU\\Sem5\\DotNet\\HDFC_Loans\\App_Data\\HDFC_Loans.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            int loanNo;

            if (!int.TryParse(txtLoanNo.Text, out loanNo))
            {
                lblMessage.Text = "Enter a valid Loan Number.";
                return;
            }
                string query = @"
                    SELECT L.*, A.ActHolderName
                    FROM Loan L
                    LEFT JOIN Account A
                    ON L.AccountNo = A.SavingActNo
                    WHERE L.LoanNo=@loanNo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@loanNo", loanNo);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtAccountNo.Text = dr["AccountNo"].ToString();
                    txtHolderName.Text = dr["ActHolderName"].ToString();
                    txtCategory.Text = dr["LoanCategory"].ToString();
                    txtLoanType.Text = dr["LoanType"].ToString();
                    txtIssueDate.Text = dr["IssueDate"].ToString();
                    txtAmount.Text = dr["Amount"].ToString();
                    txtAddress.Text = dr["CurrentAddress"].ToString();
                    txtRemarks.Text = dr["LoanRemarks"].ToString();

                    lblMessage.Text = "Record Found!";
                    btnRemove.Enabled = true;
                }
                else
                {
                    lblMessage.Text = "Loan Record Not Found!";
                    btnRemove.Enabled = false;
                }

                dr.Close();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionString);
            int loanNo;

            if (!int.TryParse(txtLoanNo.Text, out loanNo))
            {
                lblMessage.Text = "Enter a valid Loan Number.";
                return;
            }
                string query =
                    "DELETE FROM Loan WHERE LoanNo=@loanNo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@loanNo", loanNo);

                con.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    lblMessage.Text = "Record Removed Successfully!";
                    lblMessage.ForeColor =
                        System.Drawing.Color.Green;

                    txtAccountNo.Text = "";
                    txtHolderName.Text = "";
                    txtCategory.Text = "";
                    txtLoanType.Text = "";
                    txtIssueDate.Text = "";
                    txtAmount.Text = "";
                    txtAddress.Text = "";
                    txtRemarks.Text = "";

                    btnRemove.Enabled = false;
                }
                else
                {
                    lblMessage.Text = "Record Not Found!";
                }
        }
    }
}
