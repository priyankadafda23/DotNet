<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegsiterPage.aspx.cs" Inherits="demo.RegisterPage" %>


<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 320px">
            &nbsp;</p>
        <p style="margin-left: 320px">
            &nbsp;Registration Page<br />
            <br />
        <asp:Label ID="id" runat="server" Text="ID"></asp:Label>
        :
        <asp:TextBox ID="idtxt" runat="server" OnTextChanged="idtxt_TextChanged"></asp:TextBox>
            <br />
            <br />
            Name: <asp:TextBox ID="nametxt" runat="server" OnTextChanged="nametxt_TextChanged"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="passwordtxt" runat="server"></asp:TextBox>
            <br />
            <br />
            Email:
            <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
            <br />
            <br />
            Contact no.:
            <asp:TextBox ID="contactnotxt" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 320px">
            &nbsp;</p>
        <p style="margin-left: 320px">
            <asp:Button ID="submit" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
    </form>
</body>
</html>
