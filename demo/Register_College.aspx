<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register_College.aspx.cs" Inherits="demo.Register_College" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>College Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>College Registration Form</h2>

        Name:
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator
            ID="rfvName"
            runat="server"
            ControlToValidate="txtName"
            ErrorMessage="Name is required"
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <br /><br />

        Email:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator
            ID="rfvEmail"
            runat="server"
            ControlToValidate="txtEmail"
            ErrorMessage="Email is required"
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="revEmail"
            runat="server"
            ControlToValidate="txtEmail"
            ErrorMessage="Enter valid email"
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            ForeColor="Red">
        </asp:RegularExpressionValidator>

        <br /><br />

        Password:
        <asp:TextBox ID="txtPassword" runat="server"
            TextMode="Password"></asp:TextBox>

        <asp:RequiredFieldValidator
            ID="rfvPassword"
            runat="server"
            ControlToValidate="txtPassword"
            ErrorMessage="Password is required"
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <br /><br />

        Confirm Password:
        <asp:TextBox ID="txtConfirmPassword" runat="server"
            TextMode="Password"></asp:TextBox>

        <asp:CompareValidator
            ID="cvPassword"
            runat="server"
            ControlToValidate="txtConfirmPassword"
            ControlToCompare="txtPassword"
            ErrorMessage="Passwords do not match"
            ForeColor="Red">
        </asp:CompareValidator>

        <br /><br />

        Age:
<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator
    ID="rfvAge"
    runat="server"
    ControlToValidate="txtAge"
    ErrorMessage="Age is required"
    ForeColor="Red">
</asp:RequiredFieldValidator>

<asp:RegularExpressionValidator
    ID="revAge"
    runat="server"
    ControlToValidate="txtAge"
    ErrorMessage="Age must contain numbers only"
    ValidationExpression="^[0-9]+$"
    ForeColor="Red">
</asp:RegularExpressionValidator>

<asp:RangeValidator
    ID="rvAge"
    runat="server"
    ControlToValidate="txtAge"
    MinimumValue="18"
    MaximumValue="60"
    Type="Integer"
    ErrorMessage="Enter valid age"
    ForeColor="Red">
</asp:RangeValidator>

<br /><br />
        Mobile No:
        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>

        <asp:RegularExpressionValidator
            ID="revMobile"
            runat="server"
            ControlToValidate="txtMobile"
            ErrorMessage="Enter valid 10 digit mobile number"
            ValidationExpression="^[0-9]{10}$"
            ForeColor="Red">
        </asp:RegularExpressionValidator>

        <br /><br />

        Gender:

        <asp:RadioButtonList ID="rblGender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>

        <asp:RequiredFieldValidator
            ID="rfvGender"
            runat="server"
            ControlToValidate="rblGender"
            ErrorMessage="Please select gender"
            ForeColor="Red">
        </asp:RequiredFieldValidator>

        <br />

        <asp:Button ID="btnRegister" runat="server"
            Text="Register"
            OnClick="btnRegister_Click" />

        <br /><br />

        <asp:Label ID="lblMessage" runat="server"
            ForeColor="Green">
        </asp:Label>

    </form>
</body>
</html>
