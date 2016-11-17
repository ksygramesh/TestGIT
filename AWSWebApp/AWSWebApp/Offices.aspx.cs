using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AWSWebApp
{
    public partial class Offices : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                //OfficeServWebRef.OfficeServices _Client = new OfficeServWebRef.OfficeServices();
                AWSOfficSrvRef.OfficeServices _Client = new AWSOfficSrvRef.OfficeServices();
                OfficeGrid.DataSource = _Client.GetAllOffices();
                OfficeGrid.DataBind();
            }
        }
    }
}
