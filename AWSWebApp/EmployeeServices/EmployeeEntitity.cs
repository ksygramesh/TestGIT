﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeServices
{
    public class EmployeeEntitity
    {
        public EmployeeEntitity() { }

        public string employeeNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string extension { get; set; }
        public string email { get; set; }

        public string officeCode { get; set; }
        public string jobTitle { get; set; }
        public string reportsTo { get; set; }

       
    }

}