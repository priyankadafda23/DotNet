<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NewApplication.aspx.cs" Inherits="HDFC_Loans.NewApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    

    <h2 align="center">NEW LOAN APPLICATION</h2>

    <table class="form-table">
        <tr>
            <td>Saving Account No:</td>
            <td>
                <asp:TextBox ID="txtAccountNo" runat="server" />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtAccountNo"
                    ErrorMessage="Account No is required"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>Account Holder Name:</td>
            <td>
                <asp:TextBox ID="txtHolderName" runat="server" />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtHolderName"
                    ErrorMessage="Holder name is required"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>Loan Category:</td>
            <td>
                <asp:DropDownList ID="ddlCategory" runat="server">
                    <asp:ListItem>Property Loan</asp:ListItem>
                    <asp:ListItem>Personal Loan</asp:ListItem>
                    <asp:ListItem>Education Loan</asp:ListItem>
                    <asp:ListItem>Business Loan</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td>Loan Type:</td>
            <td>
                <asp:DropDownList ID="ddlLoanType" runat="server">
                    <asp:ListItem>Education Loan</asp:ListItem>
                    <asp:ListItem>Home Loan</asp:ListItem>
                    <asp:ListItem>Personal Loan</asp:ListItem>
                    <asp:ListItem>Vehicle Loan</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td>Loan Issue Date:</td>
            <td>
                <asp:TextBox ID="txtIssueDate" runat="server"
                    TextMode="Date" />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtIssueDate"
                    ErrorMessage="Issue date is required"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>Loan Amount:</td>
            <td>
                <asp:TextBox ID="txtAmount" runat="server"
                    TextMode="Number" />
                <asp:RangeValidator runat="server"
                    ControlToValidate="txtAmount"
                    MinimumValue="50000"
                    MaximumValue="2000000"
                    Type="Double"
                    ErrorMessage="Amount must be between 50000 and 2000000"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>Current Address:</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"
                    TextMode="MultiLine" Rows="3" />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtAddress"
                    ErrorMessage="Address is required"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td>Loan Remarks:</td>
            <td>
                <asp:TextBox ID="txtRemarks" runat="server"
                    TextMode="MultiLine" Rows="3" />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtRemarks"
                    ErrorMessage="Remarks are required"
                    ForeColor="Red" />
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnSubmit" runat="server"
                    Text="Submit Application"
                    OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>

    <asp:Label ID="lblMessage" runat="server"
        Font-Bold="true" />

</asp:Content>
