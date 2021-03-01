<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
            height: 22px;
            width: 1248px;
        }

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
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 62%; top: 50px; position: absolute" Text="צור משתמש והרשם עכשיו"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 80%; top: 260px; position: absolute" Text=":שם פרטי"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 85%; top: 233px; position: absolute" Text=":פרטי ילד"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" type="text" autocomplete="off" style="text-align:right;z-index: 1; left: 60%; top: 175px; position: absolute; right: 366px;"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 80%; top: 175px; position: absolute; height: 15px; width: 74px; right: 176px;" Text=":שם משפחה"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" type="number" autocomplete="off" style="text-align:right ;z-index: 1; left: 60%; top: 300px; position: absolute; right: 374px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox1" type="text" autocomplete="off" runat="server" style=" text-align:right ;z-index: 1; left: 60%; top: 255px; position: absolute; "></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 80%; top: 300px; position: absolute" Text=":תעודת זהות  "></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Font-Size="Medium" OnClick="Button1_Click" style="z-index: 1; left: 70%; top: 569px; position: absolute; height: 39px; width: 78px" Text="להרשם" />
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Medium" Font-Underline="True" ForeColor="Blue" style="z-index: 1; left: 71%; top: 621px; position: absolute" NavigateUrl="~/WebForm1.aspx">לדף הכניסה</asp:HyperLink>
        </p>
        <p>
            &nbsp;
             
        </p>
            <p>
        <asp:Label ID="Label5" runat="server" Text=":שם פרטי" style="z-index: 1; left: 80%; top: 140px; position: absolute"></asp:Label>
                <asp:Label ID="Label7" runat="server" Text=":פרטי הורה" style="z-index: 1; left: 85%; top: 100px; position: absolute"></asp:Label>
                <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 80%; top: 210px; position: absolute" Text=":תעודת זהות "></asp:Label>
        </p>
            <asp:TextBox ID="TextBox4" runat="server" type="number" autocomplete="off" style=" text-align:right;z-index: 1; left: 60%; top: 210px; position: absolute; right: 363px;"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server"  autocomplete="off" style=" text-align:right ; z-index: 1; left: 60%; top: 135px; position: absolute"></asp:TextBox>
            </form>


</body>
</html>
