using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project;
using System.Data.OleDb;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
            Label5.Text = Manager.GetParentName();
            Button1.Visible = false;
            if (Session["ParentID"] != null && !this.IsPostBack)
                {
                //Manager.SetParentName(Session["ParentID"].ToString());
                int num = int.Parse(Session["ParentID"].ToString());
                DropDownList1.Items.Add("");
                foreach (DataRow dr in ParentKidMethods.AllKidsName(num).Rows)
                {
                    DropDownList1.Items.Add(new ListItem(dr["KidsName"].ToString(), dr["KidsID"].ToString()));
                }
            }

            
           
           
            //Button[] Buttons = new Button[num];

            //int top = 280;
            //for (int i = 0; i < num; i++)
            //{
            //    Buttons[i] = new Button();
            //    Buttons[i].Width = 70;
            //    Buttons[i].Height = 30;
            //    Buttons[i].Style.Add(HtmlTextWriterStyle.Position, "absolute");
            //    Buttons[i].Style.Add(HtmlTextWriterStyle.MarginTop, top+"px");
            //    top += 40;
            //    Buttons[i].Style.Add(HtmlTextWriterStyle.MarginLeft, "47%");
            //    this.Form.Controls.Add(Buttons[i]);
                

            //}
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex > 0)
            {
                Label3.Text = DropDownList1.SelectedValue.ToString();
                Button1.Visible = true;
            }

            else
            {
                Button1.Visible = false;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx");
        }
    }
}