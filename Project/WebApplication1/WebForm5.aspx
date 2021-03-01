<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication1.WebForm5" %>
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
<div id="About" >
<p style="text-align: right;"><br />
<asp:Label ID="Label1" runat="server" Text="" style="color : white; z-index: 1; left: 95%; top: 10%; position: absolute"></asp:Label>
<asp:HyperLink ID="HyperLink1" runat="server" style="color : white; z-index: 1; left: 95%; top: 15%; position: absolute" NavigateUrl="~/WebForm1.aspx">התנתק</asp:HyperLink>
<center><h2>אתר הורים</h2></center>
<br />
.באתר זה אתם תוכלו לעקוב אחר ההתקדמות של הילדים שלכם במשחקים<br />
<br />
<br />
בכל אחד מעמודי המקצוע יהיה גליון ציונים שבו יהיה ניתן לראות פרטים לגבי הישגם של הילדים במשחקים
<br />
<br />
    אם הינכם לא רואים טבלה בעמוד הזה או באחד מן העמודים האחרים, סימן שילדכם לא סיים משחק כלשהו/לא סיים משחק בכלל**
<center> 
<%-- <img src="images/Table1.png" width="0400" height="190"  style="margin-left: 0%; margin-top: 3%;" alt="Translate">--%>
<%--<img src="images/Translate.png" width="380" height="35"  style="margin-left: 0%; margin-top: 3%; z-index: 1; left: 762px; top: 795px; position: absolute;" alt="TopTranslate">--%>
<br />
<br />

    <div id="popup" style="max-height:400px;overflow-y:scroll;">


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
    

    

    
<%--<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>--%>
<%--<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />--%>
</div>
</form>
</body>
</html>