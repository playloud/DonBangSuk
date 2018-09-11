using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSMobile.Core
{

    public static class TestUtil
    {
        public static List<PolicyProduct> GetProducts()
        {
            List<PolicyProduct> items = new List<PolicyProduct>();

            items.Add(new PolicyProduct() {
                Name = "LifeLong policy",
                ShortDescription = "this is a short description",
                LongDescription = "Hello this is a long description",
                MonthlyPayment = 23,
                MyCompany = CompanyFactory.CreateCompany(Brands.AIGDirect)
            });

            items.Add(new PolicyProduct()
            {
                Name = "LifeLong policy II",
                ShortDescription = "Better than this",
                LongDescription = "Hello this is a long description",
                MonthlyPayment = 33,
                MyCompany = CompanyFactory.CreateCompany(Brands.Ethos)
            });

            items.Add(new PolicyProduct()
            {
                Name = "FL life is Funky",
                ShortDescription = "this is a short description",
                LongDescription = "Hello this is a long description",
                MonthlyPayment = 32,
                MyCompany = CompanyFactory.CreateCompany(Brands.FidelityLife)
            });

            items.Add(new PolicyProduct()
            {
                Name = "Unified policy II",
                ShortDescription = "this is a short description",
                LongDescription = "Hello this is a long description",
                MonthlyPayment = 33,
                MyCompany = CompanyFactory.CreateCompany(Brands.GlobalLife)
            });


            return items;
        }


    }

    
}
