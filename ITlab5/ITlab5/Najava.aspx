<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="ITlab5.Najava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #E0E0E0;
        }
        .auto-style2 {
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Корисничко име</td>
                    <td>
                        <asp:TextBox ID="txtKorisnik" runat="server" Width="155px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtKorisnik" ErrorMessage="Внесете име!" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Лозинка</td>
                    <td>
                        <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password" Width="155px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLozinka" ErrorMessage="Внесете лозинка" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnPodnesi" runat="server" OnClick="btnPodnesi_Click" Text="Поднеси" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">број на обиди:<br />
                        <asp:Label ID="lblObidi" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
