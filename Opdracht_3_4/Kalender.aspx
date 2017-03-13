<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Kalender.aspx.cs" Inherits="Kalender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 23%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Selecteer een datum in de kalender</h1>
        <asp:Calendar ID="kalVerjaardag" runat="server" SelectedDate="1995-01-01" VisibleDate="1995-01-01"></asp:Calendar>
    
        <br />
        U heeft de onderstaande datum geselecteerd<br />
        <asp:Label ID="lblDatum" runat="server"></asp:Label>
        <br />
        U bent nu<br />
        <asp:Label ID="lblLeeftijd" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnLeeftijd" runat="server" Text="Laat zien" OnClick="btnLeeftijd_Click" />
    
        <br />
        <br />
        <h1 style="color:red">Het aftellen is begonnen</h1><br />
        Het is vandaag:<br />
        <asp:Literal ID="litVandaag" runat="server"></asp:Literal>
        <br />
        Het is nu:<br />
        <asp:Literal ID="litTijd" runat="server"></asp:Literal>
        <br />
        <h2>Wanneer is het pasen?</h2><br />
        <table class="auto-style1">
            <tr>
                <td>Het duurt nog</td>
                <td>
                    <asp:Label ID="lblUren" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblMinuten" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblSeconden" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnVervers" runat="server" OnClick="btnVervers_Click" Text="Ververs" />
    
    </div>
    </form>
</body>
</html>
