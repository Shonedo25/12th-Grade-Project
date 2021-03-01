<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm15.aspx.cs" Inherits="WebApplication1.WebForm15" %>

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
            &nbsp;</p>
        <p>
        <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Size="XX-Large" style="z-index: 1; left: 40%; top: 60px; position: absolute; height: 40px; width: 350px; text-align: center; bottom: 239px;" Text="הוספת ילד"></asp:Label>
        </p>
        <p>
                    <asp:Label ID="Label6" runat="server" BorderStyle="None" Font-Size="Large" style="z-index: 1; left: 38%; top: 95px; position: absolute; height: 40px; width: 386px; text-align: center; bottom: 165px;" Text="שימו לב! ניתן להוסיף ילד רק להורה אשר כבר רשום במערכת"></asp:Label>

            <asp:TextBox ID="TextBox1" runat="server" autocomplete="off" style="text-align:right;z-index: 1; left: 43%; top: 150px; position: absolute; "></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" type="number" autocomplete="off"  style="text-align:right;z-index: 1; left: 43%; top: 240px; position: absolute; "></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" autocomplete="off" style="text-align:right;z-index: 1; left: 43%; top: 195px; position: absolute; "></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" type="number" autocomplete="off" style=" text-align:right; z-index: 1; left: 43%; top: 300px; position: absolute; right: 763px;"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Font-Size="Large" style="z-index: 1; left: 53%; top: 150px; position: absolute" Text=":שם פרטי (ילד)"></asp:Label>
            <asp:Label ID="Label4" runat="server" Font-Size="Large" style="z-index: 1; left: 53%; top: 300px; position: absolute; height: 16px" Text=":תעודת זהות(הורה)"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label5" style="z-index: 1; left: 53%; top: 240px; position: absolute" runat="server" Text=":תעודת זהות (ילד)"></asp:Label>
              <asp:Label ID="Label2" style="z-index: 1; left: 53%; top: 195px; position: absolute" runat="server" Text=":שם משפחה"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" style="z-index: 1; left: 47%; top: 350px; position: absolute; height: 36px; width: 86px" Text="הוספה" />
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Large" ForeColor="Blue" NavigateUrl="~/WebForm2.aspx" style="z-index: 1; left: 43%; top: 440px; position: absolute">אין לכם משתמש? הרשמו כאן</asp:HyperLink>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" Font-Italic="False" Font-Size="Large" ForeColor="Blue" NavigateUrl="~/WebForm3.aspx" style="z-index: 1; left: 46%; top: 480px; position: absolute; height: 18px; width: 99px">כניסת הורים</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink4" runat="server" Font-Italic="False" Font-Size="Large" ForeColor="Blue" NavigateUrl="~/WebForm14.aspx" style="z-index: 1; left: 46%; top: 520px; position: absolute; height: 18px; width: 99px">הוספת הורים</asp:HyperLink>

        </p>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/WebForm1.aspx" ForeColor="Blue" style="z-index: 1; left: 47%; top: 400px; position: absolute">דף כניסה</asp:HyperLink>

    </form>
</body>
</html>