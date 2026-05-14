<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="GEASSMessManagement1.Menu" MasterPageFile="~/Site.master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:Label ID="lblWelcome" runat="server" Font-Size="Large"></asp:Label>

<h3>Select Date</h3>
<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

<br />

Select Day:
<asp:DropDownList ID="ddlDay" runat="server">
    <asp:ListItem>All</asp:ListItem>
    <asp:ListItem>Monday</asp:ListItem>
    <asp:ListItem>Tuesday</asp:ListItem>
    <asp:ListItem>Wednesday</asp:ListItem>
    <asp:ListItem>Thursday</asp:ListItem>
    <asp:ListItem>Friday</asp:ListItem>
</asp:DropDownList>

<asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="Filter_Click"/>

<br /><br />

<asp:GridView ID="GridView1" runat="server"
    Width="900px"
    Font-Size="Large"
    HeaderStyle-BackColor="Red"
    RowStyle-BackColor="Black"
    RowStyle-ForeColor="White">
</asp:GridView>

</asp:Content>