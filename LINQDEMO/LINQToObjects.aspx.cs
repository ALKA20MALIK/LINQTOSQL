using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQDEMO
{
    public partial class LINQTOOBJECTS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Employee> list = Employee.GetEmployee().Where(x => x.Gender == "Male");
            //IEnumerable<Employee> list = from x in Employee.GetEmployee()
            //                                where x.Gender == "Male"
            //                                select x;
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}