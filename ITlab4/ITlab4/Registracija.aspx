<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="ITlab4.Registracija" %>

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
            width: 108px;
        }

        .auto-style4 {
            height: 23px;
            width: 108px;
        }
        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style13 {
            width: 88px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="mvRegistracija" runat="server" ActiveViewIndex="0">
                <asp:View ID="view1" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">Име</td>
                            <td>
                                <asp:TextBox ID="txtIme" runat="server" Width="160px" ValidationGroup="g1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIme" Display="None" ErrorMessage="Внеси име!" ValidationGroup="g1"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Презиме</td>
                            <td class="auto-style2">
                                <asp:TextBox ID="txtPrezime" runat="server" Width="160px" ValidationGroup="g1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPrezime" Display="None" ErrorMessage="Внеси презиме!" ValidationGroup="g1"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">ФИНКИ ID</td>
                            <td>
                                <asp:TextBox ID="txtId" runat="server" Width="160px" ValidationGroup="g1"></asp:TextBox>
                                &nbsp;@finki.ukim.mk<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtId" Display="None" ErrorMessage="Внеси ID!" ValidationGroup="g1"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtId" Display="None" ErrorMessage="Неправилен формат на ID" ValidationExpression="^[a-z0-9_]*?\.?[a-z0-9_]*?$" ValidationGroup="g1"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Font-Size="Small" ForeColor="Gray" Text="може да ги содржи знаците a-z, 0-9, _ и максимун една точка"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Лозинка</td>
                            <td>
                                <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password" Width="160px" ValidationGroup="g1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtLozinka" Display="None" ErrorMessage="Внеси лозинка!" ValidationGroup="g1"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtLozinka" ControlToValidate="txtPotvrda" Display="None" ErrorMessage="Различни лозинки" ValidationGroup="g1"></asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Потврда</td>
                            <td>
                                <asp:TextBox ID="txtPotvrda" runat="server" TextMode="Password" Width="160px" ValidationGroup="g1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPotvrda" Display="None" ErrorMessage="Внеси потврда!" ValidationGroup="g1"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnNext1" runat="server" OnClick="btnNext1_Click" Text="&gt;&gt;" Width="60px" ValidationGroup="g1" />
                            </td>
                        </tr>
                    </table>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:ValidationSummary ID="ValidationSummary2" runat="server" Width="314px" ForeColor="Red" ValidationGroup="g1" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style13">Адреса</td>
                            <td>
                                <asp:TextBox ID="txtAdresa" runat="server" Width="160px" ValidationGroup="g2"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAdresa" ErrorMessage="Внеси адреса" ForeColor="Red" ValidationGroup="g2"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">Тел</td>
                            <td>
                                <asp:TextBox ID="txtTel" runat="server" CssClass="auto-style11" Width="160px" ValidationGroup="g2"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtTel" ErrorMessage="Внеси телефон" ForeColor="Red" ValidationGroup="g2"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtTel" ErrorMessage="Неправилен формат" ForeColor="Red" ValidationGroup="g2" ValidationExpression="^\+389 (2 \d{4}|75 \d{3}) \d{3}$"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">Пол:<asp:RadioButtonList ID="radPol" runat="server" RepeatDirection="Horizontal" ValidationGroup="g2">
                                <asp:ListItem>М</asp:ListItem>
                                <asp:ListItem>Ж</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="radPol" ErrorMessage="Избери пол" ForeColor="Red" ValidationGroup="g2"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                Датум на раѓање
                                <asp:Calendar ID="calendar" runat="server" OnSelectionChanged="Changed"></asp:Calendar>
                                <asp:Label ID="errorCalendar" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnBack2" runat="server" Text="&lt;&lt;" Width="60px" OnClick="btnBack2_Click" />&nbsp&nbsp&nbsp
                                <asp:Button ID="btnNext2" runat="server" OnClick="btnNext2_Click" Text="&gt;&gt;" Width="60px" ValidationGroup="g2" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>Занимање<br />
                                <asp:DropDownList ID="ddlZanimanje" runat="server" ValidationGroup="g3">
                                    <asp:ListItem>-занимање-</asp:ListItem>
                                    <asp:ListItem>Програмер</asp:ListItem>
                                    <asp:ListItem>Електричар</asp:ListItem>
                                    <asp:ListItem>Банкар</asp:ListItem>
                                    <asp:ListItem>Доктор</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ddlZanimanje" ErrorMessage="Изберете занимање" ForeColor="Red" InitialValue="-занимање-" ValidationGroup="g3"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Години на вршење на избраната дејност<br />
                                <asp:TextBox ID="txtGodiniVrsenje" runat="server" Width="46px" ValidationGroup="g3"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtGodiniVrsenje" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^(?:100|[1-9]?[0-9])$" ValidationGroup="g3">Недозволена вредност</asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtGodiniVrsenje" ErrorMessage="Внесете години" ForeColor="Red" ValidationGroup="g3"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnBack3" runat="server" Text="&lt;&lt;" Width="60px" OnClick="btnBack3_Click" />&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnNext3" runat="server" Text="Поднеси" Width="80px" OnClick="btnNext3_Click" ValidationGroup="g3" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="View4" runat="server">
                    <asp:Label ID="lblCreate" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="btnBack4" runat="server" OnClick="Button1_Click" Text="Врати се на почеток" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
