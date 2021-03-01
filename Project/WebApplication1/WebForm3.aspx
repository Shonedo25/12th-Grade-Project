<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parents Login</title>

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
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 47%; top: 280px; position: absolute; height: 33px; width: 73px;" Text="כניסה" Font-Size="Large" OnClick="Button1_Click" />
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 45%; top: 70px; position: absolute" Text="כניסת הורים"></asp:Label>

<asp:label runat="server" text=":שם פרטי" style="z-index: 1; left: 51%; top: 170px; position: absolute" Font-Size="Large"></asp:label>
    <asp:TextBox ID="TextBox1" runat="server" autocomplete="off" style= "text-align:right ; z-index: 1; left: 40%; top: 170px; position: absolute"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Font-Size="Large" style="z-index: 1; left: 51%; top: 220px; position: absolute" Text=":ת.ז"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" autocomplete="off" type="number" style="text-align:right ; z-index: 1; left: 40%; top: 220px; position: absolute"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Font-Size="Large" ForeColor="Red" style="z-index: 1; left: 43%; top: 120px; position: absolute; height: 15px" Text="השם או הת.ז שגוי, אנא נסו שנית"></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx" ForeColor="Blue" style="z-index: 1; left: 47%; top: 342px; position: absolute">דף כניסה</asp:HyperLink>
    </form>
    </body>
</html>
