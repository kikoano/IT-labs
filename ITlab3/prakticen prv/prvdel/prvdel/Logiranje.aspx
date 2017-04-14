<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logiranje.aspx.cs" Inherits="prvdel.Logiranje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtPoraka" runat="server" AutoPostBack="True" OnTextChanged="txtPoraka_TextChanged" ReadOnly="True" Rows="5" TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="btnProveri" runat="server" OnClick="btnProveri_Click" Text="Button" />
            <asp:Button ID="btnPrvaStrana" runat="server" Enabled="False" OnClick="btnPrvaStrana_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
