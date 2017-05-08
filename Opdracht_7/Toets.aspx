<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Toets.aspx.cs" Inherits="Toets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 28%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Tafeltester<br />
        Vul het hoogste getal in dat gebruikt mag worden in de sommen
        <asp:TextBox ID="txtHoogste" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Button" />
        <br />
        Sommen:<br />
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblSom1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtE1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="txtCheck1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSom2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtE2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="txtCheck2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblSom3" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtE3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="txtCheck3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSom4" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtE4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="txtCheck4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSom5" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtE5" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="txtCheck5" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnEnd" runat="server" Text="Button" OnClick="btnEnd_Click" />
        <br />
        <asp:Label ID="lblScore" runat="server" ForeColor="Black"></asp:Label>
    
        <br />
        <br />
        <br />
        <asp:Button ID="btnDebug" runat="server" OnClick="btnDebug_Click" Text="Debug" />
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            <asp:Label ID="lblRes1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblRes2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblRes3" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblRes4" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblRes5" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
