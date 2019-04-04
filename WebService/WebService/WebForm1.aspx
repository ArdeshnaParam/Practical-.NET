<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebService.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfValidator1" runat="server" 
            ControlToValidate="txtA" Display="Dynamic" ErrorMessage="Required Field" 
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtA" Display="Dynamic" ErrorMessage="Only Numbers Allowed" 
            ForeColor="Red" ValidationExpression="^(0|[1-9]\d*)$"></asp:RegularExpressionValidator>
    
    </div>
    <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfValidator2" runat="server" 
        ControlToValidate="txtB" Display="Dynamic" ErrorMessage="Required Field" 
        ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="txtB" ErrorMessage="Only Numbers Allowed" ForeColor="Red" 
        ValidationExpression="^(0|[1-9]\d*)$"></asp:RegularExpressionValidator>
    <br />
    <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="+" />
    <asp:Button ID="btnSub" runat="server" onclick="btnSub_Click" Text="-" />
    <asp:Button ID="btnMultiply" runat="server" onclick="btnMultiply_Click" 
        Text="*" />
    <asp:Button ID="btnDivide" runat="server" onclick="btnDivide_Click" Text="/" />
    <br />
    <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
