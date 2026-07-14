<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="demo.WebForm1" %>

<asp:Content ID="Header" ContentPlaceHolderID="Header" runat="server">
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
<form>
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input type="email" class="form-control" id="email" aria-describedby="emailHelp">
    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.<asp:RegularExpressionValidator ID="emailvalid" runat="server" ErrorMessage="Email is not valid!" ForeColor="#CC0000"></asp:RegularExpressionValidator>
      </div>
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input type="password" class="form-control" id="exampleInputPassword1">
  </div>
  <div class="mb-3 form-check">
    <input type="checkbox" class="form-check-input" id="exampleCheck1">
    <label class="form-check-label" for="exampleCheck1">Check me out</label>
  </div>
    <a href="Login.aspx" class="btn btn-primary" >Submit</a>
</form>
</asp:Content>

<asp:Content ID="Footer" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>