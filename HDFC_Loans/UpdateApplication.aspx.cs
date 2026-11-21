
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HDFC_Loans
{
    public partial class UpdateApplication : System.Web.UI.Page
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
                    WHERE L.LoanNo = @loanNo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@loanNo", loanNo);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtAccountNo.Text = dr["AccountNo"].ToString();
                    txtHolderName.Text = dr["ActHolderName"].ToString();

                    ddlCategory.SelectedValue =
                        dr["LoanCategory"].ToString();

                    ddlLoanType.SelectedValue =
                        dr["LoanType"].ToString();

                    DateTime date;

                    if (DateTime.TryParse(
                        dr["IssueDate"].ToString(), out date))
                    {
                        txtIssueDate.Text = date.ToString("yyyy-MM-dd");
                    }

                    txtAmount.Text = dr["Amount"].ToString();
                    txtAddress.Text = dr["CurrentAddress"].ToString();
                    txtRemarks.Text = dr["LoanRemarks"].ToString();

                    lblMessage.Text = "Record Found!";
                }
                else
                {
                    lblMessage.Text = "Loan Record Not Found!";
                }

            dr.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            int loanNo, accountNo;
            decimal amount;

            if (!int.TryParse(txtLoanNo.Text, out loanNo) ||
                !int.TryParse(txtAccountNo.Text, out accountNo) ||
                !decimal.TryParse(txtAmount.Text, out amount))
            {
                lblMessage.Text = "Enter valid loan, account and amount.";
                return;
            }
                con.Open();

                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    string accountQuery = @"
                        UPDATE Account
                        SET ActHolderName=@name
                        WHERE SavingActNo=@acc";

                    SqlCommand accountCmd = new SqlCommand(
                        accountQuery, con, tran);

                    accountCmd.Parameters.AddWithValue("@name",
                        txtHolderName.Text);
                    accountCmd.Parameters.AddWithValue("@acc", accountNo);

                    accountCmd.ExecuteNonQuery();

                    string query = @"
                        UPDATE Loan SET
                        AccountNo=@acc,
                        LoanCategory=@category,
                        LoanType=@type,
                        IssueDate=@date,
                        Amount=@amount,
                        CurrentAddress=@address,
                        LoanRemarks=@remarks
                        WHERE LoanNo=@loanNo";

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
                    cmd.Parameters.AddWithValue("@loanNo", loanNo);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        tran.Commit();
                        lblMessage.Text = "Record Updated Successfully!";
                        lblMessage.ForeColor =
                            System.Drawing.Color.Green;
                    }
                    else
                    {
                        tran.Rollback();
                        lblMessage.Text = "Loan Record Not Found!";
                    }
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    lblMessage.Text = "Error: " + ex.Message;
                }
        }
    }
}
