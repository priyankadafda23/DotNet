
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HDFC_Loans
{
    public partial class NewApplication : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\priya\\Desktop\\RKU\\Sem5\\DotNet\\HDFC_Loans\\App_Data\\HDFC_Loans.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            if (!Page.IsValid)
                return;

            int accountNo;
            decimal amount;

            if (!int.TryParse(txtAccountNo.Text, out accountNo) ||
                !decimal.TryParse(txtAmount.Text, out amount))
            {
                lblMessage.Text = "Enter valid account number and amount.";
                return;
            }

                con.Open();

                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    // Check whether account exists
                    string checkQuery =
                        "SELECT COUNT(*) FROM Account WHERE SavingActNo=@acc";

                    SqlCommand checkCmd = new SqlCommand(
                        checkQuery, con, tran);

                    checkCmd.Parameters.AddWithValue("@acc", accountNo);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    // Insert account if it does not exist
                    if (exists == 0)
                    {
                        string accountQuery = @"
                            INSERT INTO Account
                            (SavingActNo, ActHolderName, Profession, Email, ContactNo)
                            VALUES (@acc, @name, NULL, @email, NULL)";

                        SqlCommand accountCmd = new SqlCommand(
                            accountQuery, con, tran);

                        accountCmd.Parameters.AddWithValue("@acc", accountNo);
                        accountCmd.Parameters.AddWithValue("@name",
                            txtHolderName.Text);
                        accountCmd.Parameters.AddWithValue("@email",
                            Session["UserEmail"].ToString());

                        accountCmd.ExecuteNonQuery();
                    }

                    // Insert loan application
                    string query = @"
                        INSERT INTO Loan
                        (AccountNo, LoanCategory, LoanType, IssueDate,
                         Amount, CurrentAddress, LoanRemarks)
                        VALUES
                        (@acc, @category, @type, @date,
                         @amount, @address, @remarks)";

                    SqlCommand cmd = new SqlCommand(query, con, tran);

                    cmd.Parameters.AddWithValue("@acc", accountNo);
                    cmd.Parameters.AddWithValue("@category",
                        ddlCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@type",
                        ddlLoanType.SelectedValue);
                    cmd.Parameters.AddWithValue("@date",
                        txtIssueDate.Text);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@address",
                        txtAddress.Text);
                    cmd.Parameters.AddWithValue("@remarks",
                        txtRemarks.Text);

                    cmd.ExecuteNonQuery();

                    tran.Commit();

                    lblMessage.Text = "Record Inserted Successfully!";
                    lblMessage.ForeColor =
                        System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    lblMessage.Text = "Error: " + ex.Message;
                    lblMessage.ForeColor =
                        System.Drawing.Color.Red;
                }
        }
    }
}
