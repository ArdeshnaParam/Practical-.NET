<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtHeader" runat="server"></asp:TextBox>
<asp:Button ID="btnHeader" runat="server" onclick="btnHeader_Click" 
    Text="Change Header" />
&nbsp;
</asp:Content>
