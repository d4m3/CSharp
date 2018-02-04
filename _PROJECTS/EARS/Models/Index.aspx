<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EARS.Models.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="AUTName" HeaderText="AUTName" SortExpression="AUTName" />
                <asp:BoundField DataField="ExecutedBy" HeaderText="ExecutedBy" SortExpression="ExecutedBy" />
                <asp:BoundField DataField="RequestedBy" HeaderText="RequestedBy" SortExpression="RequestedBy" />
                <asp:BoundField DataField="BuildNo" HeaderText="BuildNo" SortExpression="BuildNo" />
                <asp:BoundField DataField="ApplicationVersion" HeaderText="ApplicationVersion" SortExpression="ApplicationVersion" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EARS_DBConnectionString %>" SelectCommand="SELECT [AUTName], [ExecutedBy], [RequestedBy], [BuildNo], [ApplicationVersion] FROM [tblTestCycle]"></asp:SqlDataSource>
    </form>
</body>
</html>
