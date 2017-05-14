<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Geometrija.aspx.cs" Inherits="MP_WebClient.Geometrija" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblVisina" runat="server" Text="Висина:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtVisina" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblRadius" runat="server" Text="Радиус:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRadius" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnPlostina" runat="server" OnClick="btnPlostina_Click" Text="Плоштина" />
                    </td>
                    <td>&nbsp;<asp:Label ID="lblPlostina" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnVolumen" runat="server" OnClick="btnVolumen_Click" Text="Волумен" Width="91px" />
                    </td>
                    <td>
                        <asp:Label ID="lblVolumen" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnInstanci" runat="server" OnClick="btnInstanci_Click" Text="Инстанци" Width="91px" />
                    </td>
                    <td>
                        <asp:Label ID="lblRezultat" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
