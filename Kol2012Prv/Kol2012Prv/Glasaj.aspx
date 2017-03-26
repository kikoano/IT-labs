<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Kol2012Prv.Glasaj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 98px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Image ID="Image1" runat="server" Height="50px" ImageUrl="~/Images/finkiLogo.png" Width="226px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblProfesor" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:ListBox ID="lstPredmeti" runat="server" AutoPostBack="True" OnSelectedIndexChanged="SelectChanged">
                            <asp:ListItem Value="Гоце Арменски">Интернет Технологии</asp:ListItem>
                            <asp:ListItem Value="Чуковски Климент">Интернет</asp:ListItem>
                            <asp:ListItem Value="Дигит Врвон">Дигитална Електроника</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td>
                        <asp:ListBox ID="lstKrediti" runat="server" AutoPostBack="True" CssClass="auto-style2" OnSelectedIndexChanged="PredmetChange">
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>5.5</asp:ListItem>
                            <asp:ListItem Value="5.51">5.5</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGlasajte" runat="server" OnClick="btnGlasajte_Click" Text="Гласајте" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
