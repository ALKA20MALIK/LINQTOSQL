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
            IEnumerable<Employee> list = Employee.GetEmployee();//.Where(x => x.Gender == "Male");
            //IEnumerable<Employee> list = from x in Employee.GetEmployee()
            //                                where x.Gender == "Male"
            //                                select x;
            GridView1.DataSource = list;
            GridView1.DataBind();
           
            Dictionary<string,int> Dict = new Dictionary<string, int>();
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var query = Numbers.Where(n => n % 2 == 0).Sum();
            Dict.Add("Sum", query);

            query = Numbers.Where(n => n % 2 == 0).Min();
            Dict.Add("Min", query);

            query = Numbers.Where(n => n %2 ==0).Max();
            Dict.Add("Max", query);

            query = Numbers.Where(n => n % 2 == 0).Count();
            Dict.Add("Count", query);

            GridView1.DataSource = Dict.ToList();
            GridView1.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}