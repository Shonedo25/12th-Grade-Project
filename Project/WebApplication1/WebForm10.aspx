<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="WebApplication1.WebForm10" %>

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
<a href="WebForm4.aspx">
<img src="images/Logo.png" width="307" height="301"  style="margin-left: 2%; margin-top: 3%;" alt="Logo">
    
</a>
</div>
<div id="menu">
<ul>
<li><a href="WebForm4.aspx">בית</a></li>
<li><a href="WebForm8.aspx">מתמטיקה</a></li>
<li><a href="WebForm9.aspx">עברית</a></li>
<li><a href="WebForm10.aspx">אנגלית</a></li>
</ul>
</div>
<div id="About">
<p style="text-align: right;"><br />
    <asp:Label ID="Label1" runat="server" Text="" style="color : white; z-index: 1; left: 95%; top: 10%; position: absolute"></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" style="color : white; z-index: 1; left: 95%; top: 15%; position: absolute" NavigateUrl="~/WebForm1.aspx">התנתק</asp:HyperLink>
<center><h2>אנגלית</h2></center>
<br />
.באתר זה אתם תוכלו ללמוד את מקצוע האנגלית <br />
<br />        
    <br />   
    מילים בעברית ותירגומן 
    <br />   
    Car - מכונית
       <br />   Door - דלת
       <br />   Mom - אמא
      <br />    Dad - אבא
     <br />     Red - אדום
       <br />   Green - ירוק
      <br />    Blue - כחול
       <br />   Black - שחור
    <br />   
    <br />   
        <asp:HyperLink ID="HyperLink2" runat="server" style="color : blue; z-index: 1; position: absolute;  left: 1140px; top: 956px;" NavigateUrl="~/Properties/1game.zip">הורדת משחק</asp:HyperLink>
    </p>


</div>


    </form>


</body>
</html>