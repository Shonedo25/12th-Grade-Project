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
    public partial class WebForm5 : System.Web.UI.Page
    {
        int num;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = " שלום , " + Manager.GetParentName();

            
            if (!this.IsPostBack)
            {
                foreach (DataRow DR in TestKidMethod.Getall(ParentKidMethods.GetKidId(Manager.GetParentId())).Rows)
                {
                    GridView1.DataSource = TestKidMethod.Getall(ParentKidMethods.GetKidId(Manager.GetParentId()));
                    GridView1.DataBind();
                }



            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label2.Text = TestKidMethod.Getall(ParentKidMethods.GetKidId(Manager.GetParentId())).Rows.Count.ToString();
            //Label2.Text = TestKidMethod.Getall(ParentKidMethods.GetKidId(123456789)).Rows.Count.ToString();
            //Label2.Text = TestKidMethod.Getall(109283475).Rows.Count.ToString();
        }
    }
}