<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Karta.aspx.cs" Inherits="PrakticnaZadaca.Karta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 130px;
        }
        .auto-style4 {
            height: 23px;
            width: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Име</td>
                <td>
                    <asp:TextBox ID="txtIme" runat="server" AutoPostBack="True" OnTextChanged="UpdateImePrezime"></asp:TextBox>
                </td>
                <td rowspan="10">
                    <asp:Panel ID="pnlPanela1" runat="server" BackColor="LightYellow" ForeColor="Blue">
                        Почитуван патнику<br />
                        <asp:Label ID="lblPatnik" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                        <br />
                        Издадена ви е карта за<br />
                        <asp:Label ID="lblSredstvo" runat="server" Font-Bold="True" Font-Italic="True"></asp:Label>
                        <br />
                        со почетна дестинација<br />
                        <asp:Label ID="lblOd" runat="server" Font-Bold="True" Font-Italic="True"></asp:Label>
                        <br />
                        и крајна дестинација<br />
                        <asp:Label ID="lblDo" runat="server" Font-Bold="True" Font-Italic="True"></asp:Label>
                        <br />
                        Времето на поаѓање е<br />
                        <asp:Label ID="lblVreme" runat="server" Font-Bold="True" Font-Italic="True"></asp:Label>
                        <br />
                        Вашето место на седење ќе биде во зоната<br /> за
                        <asp:Label ID="lblZona" runat="server" Font-Bold="True" Font-Italic="True"></asp:Label>
                        &nbsp;во
                        <asp:Label ID="lblKlasa" runat="server" Font-Bold="True" Font-Italic="True"></asp:Label>
                        &nbsp;класа<br /> и во текот на патувањето ќе бидете послужени<br /> со
                        <asp:Label ID="lblPosluga" runat="server" Font-Bold="True" Font-Italic="True"></asp:Label>
                        <br />
                        <asp:Image ID="imgSlika" runat="server" Height="187px" Width="292px" />
                        <br />
                        Ви благодариме на довербата и ви<br /> посакуваме среќен пат!</asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Презиме</td>
                <td>
                    <asp:TextBox ID="txtPrezime" runat="server" AutoPostBack="True" OnTextChanged="UpdateImePrezime"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Од</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlOd" runat="server" style="height: 22px" AutoPostBack="True" OnTextChanged="UpdateOd">
                        <asp:ListItem>Скопје</asp:ListItem>
                        <asp:ListItem>Битола</asp:ListItem>
                        <asp:ListItem>Охрид</asp:ListItem>
                        <asp:ListItem>Куманово</asp:ListItem>
                        <asp:ListItem>Прилеп</asp:ListItem>
                        <asp:ListItem>Струга</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">До</td>
                <td>
                    <asp:DropDownList ID="ddlDo" runat="server" AutoPostBack="True" OnTextChanged="UpdateDo">
                        <asp:ListItem>Скопје</asp:ListItem>
                        <asp:ListItem>Битола</asp:ListItem>
                        <asp:ListItem>Охрид</asp:ListItem>
                        <asp:ListItem>Куманово</asp:ListItem>
                        <asp:ListItem>Прилеп</asp:ListItem>
                        <asp:ListItem>Струга</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Датум на тргање</td>
                <td>
                    <asp:DropDownList ID="ddlDen" runat="server" AutoPostBack="True" OnTextChanged="UpdateDMY">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlMesec" runat="server" AutoPostBack="True" OnTextChanged="UpdateDMY">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlGodina" runat="server" AutoPostBack="True" OnTextChanged="UpdateDMY">
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2019</asp:ListItem>
                        <asp:ListItem>2020</asp:ListItem>
                        <asp:ListItem>2021</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Време на тргање</td>
                <td>
                    <asp:DropDownList ID="ddlVreme" runat="server" AutoPostBack="True" OnTextChanged="UpdateDMY">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Превозно средство</td>
                <td>
                    <asp:ListBox ID="lstSredstvo" runat="server" Height="41px" AutoPostBack="True" OnTextChanged="UpdateSredstvo">
                        <asp:ListItem>Авион</asp:ListItem>
                        <asp:ListItem>Воз</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Зона</td>
                <td>
                    <asp:RadioButtonList ID="rblZona" runat="server" AutoPostBack="True" OnTextChanged="UpdateZone">
                        <asp:ListItem>Пушачи</asp:ListItem>
                        <asp:ListItem>Непушачи</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Класа</td>
                <td>
                    <asp:RadioButtonList ID="rblKlasa" runat="server" AutoPostBack="True" OnTextChanged="UpdateKlasa">
                        <asp:ListItem>Економска</asp:ListItem>
                        <asp:ListItem>Бизнис</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Послуга</td>
                <td>
                    <asp:CheckBoxList ID="cblPosluga" runat="server" AutoPostBack="True" OnTextChanged="UpdatePosluga">
                        <asp:ListItem>Пијалок</asp:ListItem>
                        <asp:ListItem>Кафе</asp:ListItem>
                        <asp:ListItem>Оброк</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="btnPodnesi" runat="server" OnClick="btnPodnesi_Click" Text="Поднеси" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
