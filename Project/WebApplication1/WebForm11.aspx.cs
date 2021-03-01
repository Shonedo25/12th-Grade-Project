using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using Project;


namespace WebApplication1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = " שלום , " + Manager.GetParentName();

            foreach (DataRow DR in TestKidMethod.GetallMath(ParentKidMethods.GetKidId(Manager.GetParentId())).Rows)
            {
                GridView1.DataSource = TestKidMethod.GetallMath(ParentKidMethods.GetKidId(Manager.GetParentId()));
                GridView1.DataBind();
            }
        }
    }
}