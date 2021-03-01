<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm12.aspx.cs" Inherits="WebApplication1.WebForm12" %>

<!DOCTYPE html>

<html>

<head>
 <title>Main site</title>
 <link rel="stylesheet" href="./css1.css">
 <script type="text/javascript" src="script.js"></script>
 <link href="https://fonts.googleapis.com/css?family=Oswald" rel="stylesheet">
 <link href="https://fonts.googleapis.com/css?family=Ubuntu" rel="stylesheet">
</head>
<Body>
    <form id="form1" runat="server">
<div id="logo">
<a href="WebForm5.aspx">
<img src="images/Logo.png" width="307" height="301"  style="margin-left: 2%; margin-top: 3%;" alt="Logo">
    
</a>
</div>
<div id="menu">
<ul>
<li><a href="WebForm5.aspx">בית</a></li>
<li><a href="WebForm11.aspx">מתמטיקה</a></li>
<li><a href="WebForm12.aspx">עברית</a></li>
<li><a href="WebForm13.aspx">אנגלית</a></li>
</ul>
</div>
<div id="About">
<p style="text-align: right;"><br />
    <asp:Label ID="Label1" runat="server" Text="" style="color : white; z-index: 1; left: 95%; top: 10%; position: absolute"></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" style="color : white; z-index: 1; left: 95%; top: 15%; position: absolute" NavigateUrl="~/WebForm1.aspx">התנתק</asp:HyperLink>
    <center><h2>עברית</h2></center>
<br />
    <br />
    באתר הזה תוכלו לראות את תוצאות ילדיכם במשחק העברית
    <br />
    <br />
 <div id="popup" style="max-height:400px;overflow-y:scroll;">

<center>
 <asp:GridView ID="GridView1" runat="server"   CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
<AlternatingRowStyle BackColor="#CCCCCC" />
<FooterStyle BackColor="#CCCCCC" />
<HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
<PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
<SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
<SortedAscendingCellStyle BackColor="#F1F1F1" />
<SortedAscendingHeaderStyle BackColor="#808080" />
<SortedDescendingCellStyle BackColor="#CAC9C9" />
<SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView> 
</center>
    </div>
<br />

<br />
<br />
<br />
</p>
</div>
</form>


</body>
</html>
