<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ITlab6.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 400px; margin: 0 auto;">
            <table class="auto-style1">
                <tr>
                    <td style="text-align: center">
                        <asp:ListBox ID="lstCustomers" runat="server" AutoPostBack="True" Height="220px" OnSelectedIndexChanged="lstCustomers_SelectedIndexChanged" Width="300px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="lblPoraka" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Промени" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Исчисти" />
&nbsp;<asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Внеси" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style2">ID</td>
                                <td>
                                    <asp:TextBox ID="txtID" runat="server" Width="220px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Име на компанија</td>
                                <td>
                                    <asp:TextBox ID="txtCompany" runat="server" Width="220px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Име на контакт</td>
                                <td>
                                    <asp:TextBox ID="txtContact" runat="server" Width="220px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Адреса</td>
                                <td>
                                    <asp:TextBox ID="txtAddress" runat="server" Width="220px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Град</td>
                                <td>
                                    <asp:TextBox ID="txtCity" runat="server" Width="220px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">Телефон</td>
                                <td>
                                    <asp:TextBox ID="txtPhone" runat="server" Width="220px"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
