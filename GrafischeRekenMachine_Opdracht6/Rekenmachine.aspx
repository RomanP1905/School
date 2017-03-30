<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Rekenmachine.aspx.cs" Inherits="Rekenmachine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 39%;
            height: 358px;
        }
        .auto-style2 {
            margin-top: 0px;
        }
        .auto-style3 {
            height: 90px;
        }
        .auto-style4 {
            height: 70px;
        }
        .auto-style8 {
            height: 70px;
            width: 66px;
        }
        .auto-style9 {
            height: 70px;
            width: 67px;
        }
        .auto-style10 {
            width: 24%;
        }
        .auto-style11 {
            width: 294px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        De rekenmachine<br />
        <br />
        Hieronder staat een grafische rekenmachine. Druk op de knoppen om deze te gebruiken<br />
        <table class="auto-style10">
            <tr>
                <td colspan="5">
                    <asp:TextBox ID="txtScherm" runat="server" CssClass="auto-style2" Height="72px" Width="338px" Font-Size="40px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn7" runat="server" Height="62px" OnClick="btn7_Click" Text="7" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btn8" runat="server" Height="62px" OnClick="btn8_Click" Text="8" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btn9" runat="server" Height="62px" OnClick="btn9_Click" Text="9" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btnC" runat="server" Height="62px" OnClick="btnC_Click" Text="C" Width="65px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnBack" runat="server" Height="62px" OnClick="btnBack_Click" Text="Back" Width="65px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn4" runat="server" Height="62px" OnClick="btn4_Click" Text="4" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btn5" runat="server" Height="62px" OnClick="btn5_Click" Text="5" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btn6" runat="server" Height="62px" OnClick="btn6_Click" Text="6" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btnPlus" runat="server" Height="62px" OnClick="btnPlus_Click" Text="+" Width="65px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnM2" runat="server" Height="62px" Text="M2" Width="65px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn1" runat="server" Height="62px" OnClick="btn1_Click" Text="1" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btn2" runat="server" Height="62px" OnClick="btn2_Click" Text="2" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btn3" runat="server" Height="62px" OnClick="btn3_Click" Text="3" Width="65px" />
                </td>
                <td>
                    <asp:Button ID="btnMin" runat="server" Height="62px" OnClick="btnMin_Click" Text="-" Width="65px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="btnO1" runat="server" Height="62px" Text="O1" Width="65px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn0" runat="server" Height="62px" OnClick="btn0_Click" Text="0" Width="128px" />
                    </td>
                <td>
                    <asp:Button ID="btnPunt" runat="server" Height="62px" OnClick="btnPunt_Click" Text="." Width="65px" />
                    </td>
                <td>
                    <asp:Button ID="btnIs" runat="server" Height="62px" OnClick="btnIs_Click" Text="=" Width="65px" />
                    </td>
                <td class="auto-style11">
                    <asp:Button ID="btnO2" runat="server" Height="62px" Text="O2" Width="65px" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Label ID="lGetal1" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="lBereken" runat="server" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
