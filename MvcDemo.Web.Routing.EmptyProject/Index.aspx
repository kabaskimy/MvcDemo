<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MvcDemo.Web.Routing.EmptyProject.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page">
    
        <asp:GridView ID="GridViewEmployees" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="Name,Id" DataNavigateUrlFormatString="employees/{0}/{1}" DataTextField="Name" HeaderText="姓名" />
                <asp:BoundField DataField="Gender" HeaderText="性别" />
                <asp:BoundField DataField="BirthDate" DataFormatString="{0:yyyy-MM-dd}" HeaderText="出生日期" />
                <asp:BoundField DataField="Department" HeaderText="位置" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:DetailsView ID="DetailsViewEmployee" runat="server" Height="40px" Width="378px" AutoGenerateRows="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Name" HeaderText="姓名" />
                <asp:BoundField DataField="Gender" HeaderText="性别" />
                <asp:BoundField DataField="BirthDate" HeaderText="出生日期" />
                <asp:BoundField DataField="Department" HeaderText="部门" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
    </div>
        <div>
            <a href="weather/HELLO.tXt/Snow/Hi?Name=122">PathTest link</a>

            <a href="report/0755/1?say=Hi">Weather Report Link</a>
        </div>
    </form>
</body>
</html>
