<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Priemtest.aspx.cs" Inherits="Priemtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3><strong>Priem checker</strong></h3>
        <br />
        <br />
        <asp:TextBox ID="txtPriem" runat="server"></asp:TextBox>
        <asp:Button ID="btnCheck" runat="server" OnClick="btnCheck_Click" Text="Button" />
        <br />
        <asp:Label ID="lblRes" runat="server"></asp:Label>
    
        <br />
        <br />
        <h3><strong>Priem lister</strong></h3>
        <br />
        limiet<br />
        <asp:TextBox ID="txtPriem2" runat="server"></asp:TextBox>
        <asp:Button ID="btnLijst" runat="server" Text="Button" OnClick="btnLijst_Click" />
        <br />
        <div runat="server" id="lijst"></div>
    
    </div>
    </form>
</body>
</html>
