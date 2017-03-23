<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reken.aspx.cs" Inherits="Reken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 640px;
            height: 154px;
        }
        .auto-style32 {
            width: 103%;
            height: 151px;
        }
        .auto-style38 {
            width: 137px;
            height: 34px;
        }
        .auto-style39 {
            width: 168px;
            height: 34px;
        }
        .auto-style40 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style4">
    
        <table class="auto-style32">
            <tr>
                <td class="auto-style38">
                    <asp:Label ID="lblGetal1" runat="server" Text="Getal 1"></asp:Label>
                </td>
                <td class="auto-style39">
                    <asp:TextBox ID="txtGetal1" runat="server" Width="128px"></asp:TextBox>*</td>
                <td class="auto-style40">
                    <asp:Button ID="btnOptel" runat="server" OnClick="btnOptel_Click" Text="Optellen" Width="75px" />
                    <asp:RequiredFieldValidator ID="rfvGetal1" runat="server" ControlToValidate="txtGetal1" ErrorMessage="Vul getal 1 in!" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvGetal1" runat="server" ControlToValidate="txtGetal1" ErrorMessage="Tussen de 1 en 100" MaximumValue="100" MinimumValue="1" Display="Dynamic" Type="Double"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style38">
                    <asp:Label ID="lblGetal2" runat="server" Text="Getal 2"></asp:Label>
                </td>
                <td class="auto-style39">
                    <asp:TextBox ID="txtGetal2" runat="server" Width="128px"></asp:TextBox>*</td>
                <td class="auto-style40">
                    <asp:Button ID="btnAftrek" runat="server" Text="Aftrekken" OnClick="btnAftrek_Click" Height="26px" Width="75px" />
                    <asp:RequiredFieldValidator ID="rfvGetal2" runat="server" ControlToValidate="txtGetal2" ErrorMessage="Vul getal 2 in!" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvGetal2" runat="server" ControlToValidate="txtGetal2" Display="Dynamic" ErrorMessage="Zelfde getal als vak 1" ControlToCompare="txtGetal1"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style38">
                    <asp:Label ID="lblUitkomst" runat="server" Text="Uitkomst"></asp:Label>
                </td>
                <td class="auto-style39">
                    <asp:TextBox ID="txtUitkomst" runat="server" Width="128px"></asp:TextBox>
                </td>
                <td class="auto-style40"></td>
            </tr>
            <tr>
                <td class="auto-style38">

                    <asp:Label ID="lblTelefoon" runat="server" Text="Telefoonnummer"></asp:Label>
                </td>
                <td class="auto-style39">

        <asp:TextBox ID="txtTelefoon" runat="server"></asp:TextBox>

                </td>
                <td class="auto-style40">
        <asp:RegularExpressionValidator ID="reTelefoon" runat="server" ControlToValidate="txtTelefoon" ErrorMessage="Formaat: &quot;000 000000&quot;" ValidationExpression="\d{3}\s{1}\d{7}"></asp:RegularExpressionValidator>

                </td>
            </tr>
        </table>
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
