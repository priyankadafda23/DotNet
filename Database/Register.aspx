<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Database.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Registration Page</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
&nbsp;<asp:TextBox ID="idtxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="passwordtxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Contact No.:"></asp:Label>
        <asp:TextBox ID="contactnotxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" />
    </p>
</asp:Content>
