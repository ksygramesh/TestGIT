using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeServices
{
    public partial class testWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeService _client = new EmployeeService();
            List<EmployeeEntitity> _entList = _client.GetAllEmployees();
            GridView1.DataSource = _entList;
            GridView1.DataBind();

        }
    }
}