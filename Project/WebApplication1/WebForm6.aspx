<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" style="position: absolute; z-index: 1; left: 42%; top: 142px; right: 711px;" Text="תבחר אחרי איזה ילד לעקוב"></asp:Label>
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 45%; top: 70px; position: absolute" Text="כניסת הורים"></asp:Label>
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" style="z-index: 1; left: 48%; top: 220px; position: absolute"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 46%; top: 320px; position: absolute; height: 38px; width: 78px;" Text="המשך" Font-Bold="True" Font-Size="Medium" OnClick="Button1_Click" />
        <asp:Label ID="Label4" runat="server" style="position: absolute; z-index: 1; left: 52%; top: 142px" Text=" ,שלום"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="position: absolute; z-index: 1; left: 50%; top: 142px"></asp:Label>
    </form>
</body>
</html>
