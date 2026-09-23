<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="student-record.aspx.cs" Inherits="Database.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Record</p>
    <p>
        Name&nbsp;&nbsp;&nbsp; <asp:TextBox ID="namet" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p>
        Branch&nbsp;
        <asp:TextBox ID="brancht" runat="server"></asp:TextBox>
    </p>
    <p>
        Sem&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="semt" runat="server"></asp:TextBox>
    </p>
    <p>
        City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="cityt" runat="server">
            <asp:ListItem>Bhuj</asp:ListItem>
            <asp:ListItem>Rajkot</asp:ListItem>
            <asp:ListItem>Porbandar</asp:ListItem>
            <asp:ListItem>Vadodara</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Gender&nbsp;
        <asp:RadioButtonList ID="gendert" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
&nbsp;<asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Button" />
    </p>
</asp:Content>
