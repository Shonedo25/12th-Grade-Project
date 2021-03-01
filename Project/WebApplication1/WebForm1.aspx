<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
     <style type="text/css">

         input::-webkit-outer-spin-button,
         input::-webkit-inner-spin-button {
         -webkit-appearance: none;
          margin: 0;
        }

         /* Firefox */
         input[type=number] {
         -moz-appearance:textfield;
         }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Size="XX-Large" style="z-index: 1; left: 38%; top: 60px; position: absolute; height: 40px; width: 350px; text-align: center" Text="ברוכים הבאים לאתר התרגול"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label6" Font-Size="Large" style="z-index: 1; left: 41%; top: 115px; position: absolute; height: 40px; width: 253px; text-align: center" runat="server" Text="כניסת ילדים"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Size="Large" style="position: absolute; z-index: 1; left: 44%; top: 161px; margin-bottom: 0px" Text="אנא הכנסו למשתמש שלכם"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" autocomplete="off" style="text-align:right ;z-index: 1; left: 40%; top: 289px; position: absolute; right: 621px" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" type="number" autocomplete="off" style="text-align:right;z-index: 1; left: 40%; top: 350px; position: absolute; right: 763px;"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Font-Size="Large" style="z-index: 1; left: 50%; top: 291px; position: absolute" Text=":שם פרטי"></asp:Label>
            <asp:Label ID="Label4" runat="server" Font-Size="Large" style="z-index: 1; left: 50%; top: 350px; position: absolute; height: 16px" Text=":תעודת זהות"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Font-Size="Medium" style="z-index: 1; left: 43%; top: 197px; position: absolute" Text="השם או הת.ז שגוי, אנא נסו שנית" Font-Bold="True" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink3" Font-Size="Large" style="z-index: 1; left: 46%; top: 590px; position: absolute" runat="server" Font-Underline="True" ForeColor="Blue" NavigateUrl="~/WebForm14.aspx">הוספת הורה</asp:HyperLink>
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Large" ForeColor="Blue" NavigateUrl="~/WebForm2.aspx" style="z-index: 1; left: 43%; top: 515px; position: absolute">אין לכם משתמש? הרשמו כאן</asp:HyperLink>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" Font-Italic="False" Font-Size="Large" ForeColor="Blue" NavigateUrl="~/WebForm3.aspx" style="z-index: 1; left: 46%; top: 550px; position: absolute; height: 18px; width: 99px">כניסת הורים</asp:HyperLink>
        </p>
        <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" style="z-index: 1; left: 47%; top: 445px; position: absolute; height: 36px; width: 86px" Text="כניסה" />
    </form>
</body>
</html>
