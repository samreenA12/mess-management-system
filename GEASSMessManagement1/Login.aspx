<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GEASSMessManagement1.Login" MasterPageFile="~/Site.master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h2>GEASS Student Login</h2>

Username:
<asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvUser" runat="server"
    ControlToValidate="txtUser"
    ErrorMessage="* Enter Username"
    ForeColor="Red" />

<br />

Password:
<asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
<asp:RequiredFieldValidator ID="rfvPass" runat="server"
    ControlToValidate="txtPass"
    ErrorMessage="* Enter Password"
    ForeColor="Red" />

<br /><br />

<asp:Button ID="btnLogin" runat="server" Text="Enter Geass" OnClick="Login_Click"/>

<br />
<asp:Label ID="lblMsg" runat="server"></asp:Label>

</asp:Content>