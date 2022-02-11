<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LINQTODATASET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <title>Bind Gridview with LINQ to ADO.NET Operations</title>
<style type="text/css">
.GridviewDiv {font-size: 100%; font-family: 'Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helevetica, sans-serif; color: #303933;}
.headerstyle
{
color:#FFFFFF;border-right-color:#abb079;border-bottom-color:#abb079;background-color: #df5015;padding:0.5em 0.5em 0.5em 0.5em;text-align:center;
}
</style>
</head>
<body>
<form id="form2" runat="server">
<div class="GridviewDiv">
<asp:GridView ID="gvDetails" CssClass="Gridview" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvDetails_SelectedIndexChanged">
<HeaderStyle CssClass="headerstyle" />
<Columns>
<asp:BoundField HeaderText="Name" DataField="Name" />
<asp:BoundField HeaderText="Location" DataField="Location" />
<asp:BoundField HeaderText="Gender" DataField="Gender" />
</Columns>
</asp:GridView>
</div>
</form>
</body>
</html>
   