using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace OfficesServices
{
    /// <summary>
    /// Summary description for OfficeServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OfficeServices : System.Web.Services.WebService
    {

        private string constr;
        private MySqlConnection sqlcon = null;

        public OfficeServices()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
            constr = ConfigurationManager.ConnectionStrings["Sqlconstr"].ConnectionString;
        }

        [WebMethod]
        public List<OfficeEntitity> GetAllOffices()
        {
            List<OfficeEntitity> _officesList = new List<OfficeEntitity>();
            try
            {
                 sqlcon = new MySqlConnection(constr);
                sqlcon.Open();
               // string sqlQeury=@"select employeeNumber,lastName,firstName,extension,email,officeCode,reportsTo,jobTitle from employees";
                string sqlQeury = @"select * from offices";
                MySqlCommand sqlcmd = new MySqlCommand(sqlQeury, sqlcon);
                MySqlDataReader sqlrdr = sqlcmd.ExecuteReader();
                while (sqlrdr.Read())
                {
                    OfficeEntitity officeObj = new OfficeEntitity
                        {
                            officeCode  =  sqlrdr[OfficesConstant.officeCode].ToString(),
                            city = sqlrdr[OfficesConstant.city].ToString(),
                            addressLine1 = sqlrdr[OfficesConstant.addressLine1].ToString(),
                            addressLine2 = sqlrdr[OfficesConstant.phone].ToString(),
                            phone = sqlrdr[OfficesConstant.phone].ToString(),
                            state = sqlrdr[OfficesConstant.state].ToString(),
                            territory = sqlrdr[OfficesConstant.territory].ToString(),
                            country = sqlrdr[OfficesConstant.country].ToString()
                        };
                    _officesList.Add(officeObj);
                }
                sqlcon.Clone();             

            }
            catch (Exception e)
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Clone();
                }
            }

            return _officesList;

        }
    }
}
