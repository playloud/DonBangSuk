using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSMobile.Core
{
    public class PolicyProduct
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal MonthlyPayment { get; set; }
        public Company MyCompany { get; set; }
        public string CompanyName { get { return MyCompany.BrandName; }}
        public string CompanyImagePath { get { return MyCompany.LogoPath; } }

    }


}
