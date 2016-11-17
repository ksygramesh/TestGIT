using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficesServices
{
    public class OfficeEntitity
    {
        public OfficeEntitity() { }

        public string officeCode { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }

        public string state { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string territory { get; set; }
      
    }

}