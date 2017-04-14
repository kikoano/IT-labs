<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GlavnaStranica.aspx.cs" Inherits="ITlab5.GlavnaStranica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Најавен корисник:&nbsp;
            <asp:Label ID="lblKorisnik" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            Најавени корисници:<br />
            <asp:Label ID="lblNajaveniKorisnici" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            Вкупно најавени корисници:&nbsp; <asp:Label ID="lblKorisnici" runat="server" ForeColor="Blue"></asp:Label>
            <br />
            <asp:Panel ID="pnlPanela1" runat="server" Width="390px">
                <asp:DropDownList ID="ddPozadina" runat="server" AutoPostBack="True" Height="17px" OnSelectedIndexChanged="ddPozadina_SelectedIndexChanged" Width="110px">
                </asp:DropDownList>
                <asp:DropDownList ID="ddFont" runat="server" AutoPostBack="True" Height="17px" OnSelectedIndexChanged="ddFont_SelectedIndexChanged" Width="110px">
                </asp:DropDownList>
                <br />
                <asp:Label ID="lblPoraka" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnZacuvaj" runat="server" OnClick="btnZacuvaj_Click" Text="Зачувај" />
                &nbsp;&nbsp;
                <asp:Button ID="btnOdjava" runat="server" OnClick="btnOdjava_Click" Text="Одјава" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
