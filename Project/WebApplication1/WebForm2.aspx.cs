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
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label5.Visible = false;
            //Label6.Visible = false;
            //TextBox4.Visible = false;
            //TextBox5.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length != 9 || TextBox4.Text.Length !=9)
            {
                Page.Controls.Add(new LiteralControl("<script language='javascript'> window.alert('אנא הכנס מספר ת.ז תקף')</script>"));
              

            }

            else
            {
                if (TextBox1.Text.Length != 0 && TextBox2.Text.Length != 0 && TextBox3.Text.Length == 9 && TextBox4.Text.Length == 9 && TextBox5.Text.Length != 0)
                {
                 

                        KidsMethods.AddKid(int.Parse(TextBox3.Text), TextBox1.Text, TextBox2.Text);
                        ParentsMethods.AddParent(int.Parse(TextBox4.Text), TextBox5.Text, TextBox2.Text);
                        ParentKidMethods.AddParentKid(int.Parse(TextBox4.Text), int.Parse(TextBox3.Text));
                        Page.Controls.Add(new LiteralControl("<script language='javascript'> window.alert('אנא הכנס מספר ת.ז תקף')</script>"));
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        Response.Redirect("WebForm1.aspx");
                   
                }

                else
                {
                    Page.Controls.Add(new LiteralControl("<script language='javascript'> window.alert('אנא בדוק שכל השדות מלאים בצורה נכונה')</script>"));
                }


 


            }
        }


    }
}