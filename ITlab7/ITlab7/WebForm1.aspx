<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ITlab7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvSuppliers" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="3" DataKeyNames="SupplierID" GridLines="Vertical" OnPageIndexChanging="gvSuppliers_PageIndexChanging" OnRowCancelingEdit="gvSuppliers_RowCancelingEdit" OnRowEditing="gvSuppliers_RowEditing" OnRowUpdating="gvSuppliers_RowUpdating" OnSelectedIndexChanged="gvSuppliers_SelectedIndexChanged" PageSize="12" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:ButtonField CommandName="select" DataTextField="SupplierID" HeaderText="ID" Text="ID" />
                <asp:BoundField DataField="CompanyName" HeaderText="Компанија" ReadOnly="True" />
                <asp:BoundField DataField="ContactName" HeaderText="Контакт" />
                <asp:BoundField DataField="Phone" HeaderText="Телефон" />
                <asp:BoundField DataField="City" HeaderText="Град" />
                <asp:CommandField CancelText="Откажи" EditText="Уреди" ShowEditButton="True" UpdateText="Промени" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:Label ID="lblPoraka" runat="server"></asp:Label>
    
    </div>
        <asp:GridView ID="gvProducts" runat="server" Visible="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </form>
</body>
</html>
