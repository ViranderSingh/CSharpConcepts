using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CreatingIndexer
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            //We are using get accessor of the employeeId indexer to get the names of the employees
            Response.Write("Name of Employee with Id = 2: " + company[2] + "<br/>");
            Response.Write("Name of Employee with Id = 5: " + company[5] + "<br/>");
            Response.Write("Name of Employee with Id = 8: " + company[8] + "<br/><br/>");

            Response.Write("Changing names of the employees with ID = 2, 5 & 8" + "<br/><br/>");

            //We are using set accessor of the employeeId indexer to change the names of the employees
            company[2] = "2nd Employee Name Changed";
            company[5] = "5th Employee Name Changed";
            company[8] = "8th Employee Name Changed";

            Response.Write("Name of Employee with Id = 2: " + company[2] + "<br/>");
            Response.Write("Name of Employee with Id = 5: " + company[5] + "<br/>");
            Response.Write("Name of Employee with Id = 8: " + company[8] + "<br/><br/>");

            Response.Write("Before Update" + "<br/>");
            Response.Write("Total Male Employees = " + company["Male"] + "<br/>");
            Response.Write("Total Female Employees = " + company["Female"] + "<br/>"+ "<br/>");

            company["Male"] = "Female";

            Response.Write("After Update" + "<br/>");
            Response.Write("Total Male Employees = " + company["Male"] + "<br/>");
            Response.Write("Total Female Employees = " + company["Female"] + "<br/>" + "<br/>");
        }
    }
}