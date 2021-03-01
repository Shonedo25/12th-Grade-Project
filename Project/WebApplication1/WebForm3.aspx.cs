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
    public partial class WebForm3 : System.Web.UI.Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 9)
            {


                if (TextBox1.Text.Length != 0 && TextBox2.Text.Length != 0)
                {

                    if (ParentsMethods.check(TextBox1.Text, int.Parse(TextBox2.Text)))
                    {

                        Manager.SetParentName(TextBox1.Text);
                        Session["ParentID"] = TextBox2.Text;
                        Manager.SetParentId(int.Parse(TextBox2.Text));
                        if (ParentKidMethods.HowMuch(int.Parse(TextBox2.Text)) > 1)
                        {
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            Response.Redirect("WebForm6.aspx");
                        }

                        else
                        {
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            Response.Redirect("WebForm5.aspx");
                        }

                    }


                    else
                    {
                        Label3.Visible = true;
                    }
                }

                else
                {
                    Label3.Visible = true;
                }
            }
            else
            {
                Page.Controls.Add(new LiteralControl("<script language='javascript'> window.alert('אנא הכנס מספר ת.ז תקף')</script>"));
            }
        }
    }
}