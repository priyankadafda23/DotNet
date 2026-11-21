<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateApplication.aspx.cs" Inherits="HDFC_Loans.UpdateApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <h2 align="center">UPDATE LOAN APPLICATION</h2>

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
                <asp:TextBox ID="txtAccountNo" runat="server" />
            </td>
        </tr>

        <tr>
            <td>Account Holder Name:</td>
            <td>
                <asp:TextBox ID="txtHolderName" runat="server" />
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
            </td>
        </tr>

        <tr>
            <td>Loan Amount:</td>
            <td>
                <asp:TextBox ID="txtAmount" runat="server" />
            </td>
        </tr>

        <tr>
            <td>Current Address:</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"
                    TextMode="MultiLine" />
            </td>
        </tr>

        <tr>
            <td>Loan Remarks:</td>
            <td>
                <asp:TextBox ID="txtRemarks" runat="server"
                    TextMode="MultiLine" />
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnUpdate" runat="server"
                    Text="Update Application"
                    OnClick="btnUpdate_Click" />
            </td>
        </tr>
    </table>

    <asp:Label ID="lblMessage" runat="server" />

</asp:Content>
