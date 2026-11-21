<%@ Page Title="" Language="C#" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs"
    Inherits="HDFC_Loans.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>HDFC Loans - Login</title>

    <style>
        body {
            font-family: "Times New Roman";
            margin: 20px;
        }

        .login-box {
            width: 400px;
            margin: 100px auto;
            padding: 20px;
        }

        .login-box h2 {
            text-align: center;
            margin-bottom: 25px;
        }

        .login-box table {
            width: 100%;
        }

        .login-box td {
            padding: 5px;
            font-size: 18px;
        }

        .login-box input[type="text"],
        .login-box input[type="password"] {
            width: 190px;
            height: 22px;
        }

        .login-button {
            text-align: center;
        }

        .message {
            text-align: center;
        }
    </style>
</head>

<body>

<form id="form1" runat="server">

    <div class="login-box">

        <h2>User Login</h2>

        <table>

            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server">
                    </asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"
                        TextMode="Password">
                    </asp:TextBox>
                </td>
            </tr>

            <tr>
                <td colspan="2" class="login-button">
                    <asp:Button ID="btnLogin" runat="server"
                        Text="Sign In"
                        OnClick="btnLogin_Click" />
                </td>
            </tr>

        </table>

        <div class="message">
            <asp:Label ID="lblMessage" runat="server">
            </asp:Label>
        </div>

    </div>

</form>

</body>
</html>
