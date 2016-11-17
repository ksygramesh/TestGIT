using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OfficesServices
{
    public partial class testWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OfficeServices _client = new OfficeServices();
            List<OfficeEntitity> _entList = _client.GetAllOffices();
            GridView1.DataSource = _entList;
            GridView1.DataBind();
            
        }
    }
}