using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQDEMO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext DataContext = new SampleDataContext();
            GridView1.DataSource = from s in DataContext.Students
                                   where s.Gender == "Female"
                                   select s;
            GridView1.DataBind();

           
            GridView2.DataSource = ( from pd in DataContext.xtOrders
                    join od in DataContext.xtSales on pd.OrderId equals od.OrderId
                     orderby od.OrderId
                     select new
                     {                       
                         pd.DepNo,
                         pd.Amount,
                         od.SalesManId
                     }).ToList();
            GridView2.DataBind();

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {




        }
    }
}