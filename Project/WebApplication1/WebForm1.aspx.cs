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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            Label5.Visible = false;
            //HyperLink2.Visible = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 9)
            {


                if (TextBox1.Text.Length != 0 && TextBox2.Text.Length != 0)
                {

                    if (KidsMethods.check(TextBox1.Text, int.Parse(TextBox2.Text)))
                    {
                        
                        
                        Manager.SetKidId(int.Parse(TextBox2.Text));
                        Manager.SetKidId(int.Parse(TextBox2.Text));
                        Manager.SetKidName(TextBox1.Text);
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        Response.Redirect("WebForm4.aspx");


                    }


                    else
                    {
                        Label5.Visible = true;
                    }
                }

                else
                {
                    Label5.Visible = true;
                }
            }

            else
            {
                Page.Controls.Add(new LiteralControl("<script language='javascript'> window.alert('אנא הכנס מספר ת.ז תקין')</script>"));
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {
            
        }
    }
}