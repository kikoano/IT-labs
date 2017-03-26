<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rezultati.aspx.cs" Inherits="Kol2012Prv.Rezultati" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 157px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="lstPredmeti" runat="server"></asp:ListBox>
                    </td>
                    <td>
                        <asp:ListBox ID="lstPoeni" runat="server"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
