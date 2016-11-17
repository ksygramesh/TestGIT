

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AWSWebApp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // EmployeeServiceRef.EmployeeServiceSoapClient _empClient = new EmployeeServiceRef.EmployeeServiceSoapClient();
                AWSEmpSrvRef.EmployeeService _empClient = new AWSEmpSrvRef.EmployeeService();

                EmpGrid.DataSource = _empClient.GetAllEmployees();
                EmpGrid.DataBind();
            }
        }
    }
}