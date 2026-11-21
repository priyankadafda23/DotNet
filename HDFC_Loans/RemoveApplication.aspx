<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RemoveApplication.aspx.cs" Inherits="HDFC_Loans.RemoveApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <h2 align="center">DISCARD LOAN APPLICATION</h2>

    <table class="form-table">
        <tr>
            <td>Loan No:</td>
            <td>
                <asp:TextBox ID="txtLoanNo" runat="server" />
                <asp:Button ID="btnGet" runat="server"
                    Text="Get Loan Details"
                    CausesValidation="false"
                    OnClick="btnGet_Click" />
            </td>
        </tr>

        <tr>
            <td>Saving Account No:</td>
            <td>
                <asp:TextBox ID="txtAccountNo" runat="server"
                    ReadOnly="true" />
            </td>
        </tr>

        <tr>
            <td>Account Holder Name:</td>
            <td>
                <asp:TextBox ID="txtHolderName" runat="server"
                    ReadOnly="true" />
            </td>
        </tr>

        <tr>
            <td>Loan Category:</td>
            <td>
                <asp:TextBox ID="txtCategory" runat="server"
                    ReadOnly="true" />
            </td>
        </tr>

        <tr>
            <td>Loan Type:</td>
            <td>
                <asp:TextBox ID="txtLoanType" runat="server"
                    ReadOnly="true" />
            </td>
        </tr>

        <tr>
            <td>Loan Issue Date:</td>
            <td>
                <asp:TextBox ID="txtIssueDate" runat="server"
                    ReadOnly="true" />
            </td>
        </tr>

        <tr>
            <td>Loan Amount:</td>
            <td>
                <asp:TextBox ID="txtAmount" runat="server"
                    ReadOnly="true" />
            </td>
        </tr>

        <tr>
            <td>Current Address:</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"
                    TextMode="MultiLine" ReadOnly="true" />
            </td>
        </tr>

        <tr>
            <td>Loan Remarks:</td>
            <td>
                <asp:TextBox ID="txtRemarks" runat="server"
                    TextMode="MultiLine" ReadOnly="true" />
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnRemove" runat="server"
                    Text="Discard Application"
                    OnClick="btnRemove_Click"
                    OnClientClick="return confirm('Are you sure you want to discard this application?');" />
            </td>
        </tr>
    </table>

    <asp:Label ID="lblMessage" runat="server" />

</asp:Content>
