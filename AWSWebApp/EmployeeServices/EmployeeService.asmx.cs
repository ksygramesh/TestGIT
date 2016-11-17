using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace EmployeeServices
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        private string constr;
        private MySqlConnection sqlcon = null;

        public EmployeeService()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
            constr = ConfigurationManager.ConnectionStrings["Sqlconstr"].ConnectionString;
        }

        [WebMethod]
        public List<EmployeeEntitity> GetAllEmployees()
        {
            List<EmployeeEntitity> _employeeList = new List<EmployeeEntitity>();
            try
            {
                 sqlcon = new MySqlConnection(constr);
                sqlcon.Open();
               // string sqlQeury=@"select employeeNumber,lastName,firstName,extension,email,officeCode,reportsTo,jobTitle from employees";
                string sqlQeury = @"select * from employees";
                MySqlCommand sqlcmd = new MySqlCommand(sqlQeury, sqlcon);
                MySqlDataReader sqlrdr = sqlcmd.ExecuteReader();
                while (sqlrdr.Read())
                {
                    EmployeeEntitity empObj = new EmployeeEntitity
                        {
                            employeeNumber =  sqlrdr[EmployeeConstant.employeeNumber].ToString(),
                            lastName = sqlrdr[EmployeeConstant.lastName].ToString(),
                            firstName = sqlrdr[EmployeeConstant.firstName].ToString(),
                            extension = sqlrdr[EmployeeConstant.extension].ToString(),
                            email = sqlrdr[EmployeeConstant.email].ToString(),
                            reportsTo = sqlrdr[EmployeeConstant.reportsTo].ToString(),
                            officeCode = sqlrdr[EmployeeConstant.officeCode].ToString(),
                            jobTitle = sqlrdr[EmployeeConstant.jobTitle].ToString()
                        };
                    _employeeList.Add(empObj);
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

            return _employeeList;

        }
    }
}
