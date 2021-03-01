<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>
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
<div id="About" style=" height : 1800px;">
<p style="text-align: right;"><br />
    <asp:Label ID="Label1" runat="server" Text="" style="color : white; z-index: 1; left: 95%; top: 10%; position: absolute"></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" style="color : white; z-index: 1; left: 95%; top: 15%; position: absolute" NavigateUrl="~/WebForm1.aspx">התנתק</asp:HyperLink>
<center><h2>אתר ילדים</h2></center>
<br />
.באתר זה אתם תוכלו ללמוד את מקצועות היסוד: מתמטיקה, עברית ואנגלית<br />
<br />
.האתר מחולק לארבעה חלקים, כל חלק מתרכז במקצוע שונה, עלמנת לעבור בין המקצועות עליך להשתמש בסרגל שנמצא למעלה<br />
<br />

<br />
    .בכל חלק של האתר יהיה תוכן עיוני על כל מקצוע ולאחר מכן יהיה משחק שכל אחד יוכל להוריד ולשחק. התוצאות של המשחק (תאריך, תוצאה) ישמרו במערכת, ויהיה ניתן לעקוב אחריהם
    <br />   

    <center><h2>שלבים להורדת המשחק</h2></center>
    <br />
    יש ללחוץ על הקישור הכחול בכל עמוד מקצוע
    <center><img src="images/ss1.png" width="0400" height="190"  style="margin-left: 0%; margin-top: 3%;" alt="Translate"></center>
        <br />
    <br />
    <br />
    יש לבחור מקום שמירה (בצד שמאל) ואז יש ללחוץ על הכפתור שמירה (צד ימין) 
        <center><img src="images/ss2.png" width="0400" height="190"  style="margin-left: 0%; margin-top: 3%;" alt="Translate"></center>
            <br />
    <br />

    <br />
          שמופיע באדום Extract Here  תלחצו על הקובץ בעזרת המקש העכבר הימני ולאחר מכן תלחצו על הכפתור
    <center><img src="images/ss31.png" width="0400" height="190"  style="margin-left: 0%; margin-top: 3%;" alt="Translate"></center>

                <br />
    <br />

    <br />
      שמופיעה למעלה באדום Debug תלחצו על תיקיית ה
 <br /> 
      שמוקף באדום למטה .exe ואז תלחצו על קובץ ה
      <center><img src="images/ss5.png" width="0400" height="190"  style="margin-left: 0%; margin-top: 3%;" alt="Translate"></center>
    </p>
     

</div>

    </form>


</body>
</html>