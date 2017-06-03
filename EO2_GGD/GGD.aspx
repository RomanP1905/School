<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GGD.aspx.cs" Inherits="GGD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
    <div>
        
        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        <asp:Button ID="btnCheck" runat="server" OnClick="btnCheck_Click" Text="Button" />
        <br />
        <asp:Label ID="lblGGD" runat="server"></asp:Label>
        
    </div>
    </form>
</body>
</html>
