using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClasses
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             

            Customer C1 = new Customer();
            C1.FirstName = "Virander";
            C1.LastName = "Singh";
            string FullName1 = C1.GetFullName();
            Response.Write("Full Name = " + FullName1 + "<br/>");

            PartialCustomerClass C2 = new PartialCustomerClass();
            C2.FirstName = "Virander";
            C2.LastName = "Singh Sardar";
            string FullName2 = C2.GetFullName();
            Response.Write(FullName2 + "<br/>");
        }
    }
}