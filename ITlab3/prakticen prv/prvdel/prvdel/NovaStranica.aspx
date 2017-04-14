<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovaStranica.aspx.cs" Inherits="prvdel.NovaStranica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" align="center">
                <tr>
                    <td>
                        <asp:Panel ID="pnlPanela1" runat="server" BackColor="#FFFF99">
                            <asp:TextBox ID="txtOperand1" runat="server" EnableViewState="False"></asp:TextBox>
                            <asp:TextBox ID="txtOperand2" runat="server" AutoPostBack="True"></asp:TextBox>
                            <asp:Label ID="lblRezultat" runat="server" EnableViewState="False" Text="Label"></asp:Label>
                            <asp:Button ID="btnOdzemi" runat="server" OnClick="btnOdzemi_Click" Text="Button" />
                        </asp:Panel>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="chbVidlivo" runat="server" AutoPostBack="True" OnCheckedChanged="chbVidlivo_CheckedChanged" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
