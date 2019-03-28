<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ValidationControls.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtName" Display="Dynamic" ErrorMessage="Please Enter Name" 
            ForeColor="Red">*</asp:RequiredFieldValidator>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Enter valid email" 
        ForeColor="Red" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Mobile"></asp:Label>
        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="txtMobile" ErrorMessage="Enter valid Mobile number" 
            ForeColor="Red" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtPassword" ControlToValidate="txtConfirm" Display="Dynamic" 
            ErrorMessage="CompareValidator" ForeColor="Red"></asp:CompareValidator>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Semester"></asp:Label>
        <asp:TextBox ID="txtSemester" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="txtSemester" ErrorMessage="RangeValidator" ForeColor="Red" 
            MaximumValue="8" MinimumValue="1" Type="Integer"></asp:RangeValidator>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
