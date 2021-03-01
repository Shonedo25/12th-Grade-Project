using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;
using System.Data.OleDb;

namespace WebApplication1
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 9)
            {


                if (TextBox1.Text.Length != 0 && TextBox2.Text.Length != 0)
                {

                    if (KidsMethods.checkID( int.Parse(TextBox2.Text)))
                    {
                        Page.Controls.Add(new LiteralControl("<script language='javascript'> window.alert('נרשמת בהצלחה! אנא הכנס למערכת מהאתר המתאים')</script>"));
                        Manager.SetKidId(int.Parse(TextBox2.Text));
                        ParentsMethods.AddParent(int.Parse(TextBox3.Text), TextBox1.Text, TextBox4.Text);
                        ParentKidMethods.AddParentKid(int.Parse(TextBox3.Text), int.Parse(TextBox2.Text));
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        Response.Redirect("WebForm1.aspx");


                    }
                }
            }

            else
            {
                Page.Controls.Add(new LiteralControl("<script language='javascript'> window.alert('אנא הכנס מספר ת.ז תקין')</script>"));
            }
        }
    }
}