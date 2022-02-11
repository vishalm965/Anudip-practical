using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINKTOXML
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XElement doc = XElement.Load(Server.MapPath("EmployeeDetails.xml"));
            var result = from ed in doc.Descendants("employee")
                         where Convert.ToInt32(ed.Element("salary").Value) >= 20000
                         select new
                         {
                             Id = ed.Element("empid").Value,
                             Name = ed.Element("empname").Value,
                             Salary = ed.Element("salary").Value,
                             Gender = ed.Element("gender").Value
                         };
            GridView.DataSource = result;
            GridView.DataBind();
        }
    }
}
