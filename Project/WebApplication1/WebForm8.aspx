<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication1.WebForm8" %>

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
<center><h2>מתמטיקה</h2></center>
<br />
    .באתר זה אתם תוכלו ללמוד את מקצוע המתמטיקה
<br />
<br />
       <b>פעולת החיבור -</b> בפעולת החיבור מחברים שני מספרים למספר אחד גדול יותר 
 
<br />
התוצאה שיוצאת מהחיבור תמיד תהיה יותר גדולה מהשתי מספרים שחיברו
<br />
<br />   
    לדוגמא: 2 + 3 = 5
<br />
    .הוספנו למספר 2 את המספר 3, ואם נספור את האצבעות - 2 אצבעות ועוד 3 אצבעות = 5 אצבעות
    <br />
    <br />
    <b>פעולת החיסור - </b>  פעולת החיסור מאוד דומה לפעולת החיבור ובה מחסירים מספר אחד מהשני. בפעולת החיסור יש את המחסר והמחוסר
    <br />
    .בחיסור, לא כמו בחיבור, זה משנה איפה כל מספר נמצא
    <br />
    <br />
       <b> פעולת הכפל - </b> כפל של מספרים הוא למעשה פעולת חיבור חוזרת: 4 כפול 3 הוא הסכום של הוספה של המספר 3 - 4 פעמים. 3+3+3+3=12
      <br />
    <br />
    <b>פעולת החילוק - </b>חילוק היא פעולה ההפוכה לכפל. בפעולת חילוק נתונים שני מספרים. הראשון שאותו מחלקים, נקרא מחולק. והשני ,שבו מחלקים את הראשון, נקרא מחלק. המספר המתקבל כתוצאה מהחילוק נקרא מנה


          <br />
    <br />

    <b>סדר הפעולות - </b>חיבור,חיסור  <  כפל,חילוק  <  סוגריים
        <br />
    בתחילת כל תרגיל קודם תמיד עושים את הפעולה שבתוך הסוגריים ואחר כך את פעולת הכפל והחילוק, ואז החיבור
     <br />
     <br />
    <asp:HyperLink ID="HyperLink2" runat="server" style="color : blue; z-index: 1; position: absolute;  left: 1140px;" NavigateUrl="~/Properties/3game.zip">הורדת משחק</asp:HyperLink>
    <br />
    <br />
    <br />
</p>


</div>


    </form>


</body>
</html>