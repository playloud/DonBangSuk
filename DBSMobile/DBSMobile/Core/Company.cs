using System;
using System.Collections.Generic;
using System.Text;

namespace DBSMobile.Core
{
    public enum Brands
    {
        AIGDirect,
        HealthIQ,
        AmericanNational,
        HavenLife,
        Ethos,
        PolicyGenius,
        FidelityLife,
        Trustage,
        NationalFamily
    }

    public class Company
    {
        public Brands Brand { get; set; }
        public string BrandName {
            get
            {
                return CompanyUtil.GetBrandsName(Brand);
            }
        }
        public string LogoPath {
            get
            {
                return CompanyUtil.GetCompanyImagePath(Brand);
            }
        }

    }

    public static class CompanyFactory
    {
        public static Company CreateCompany(Brands brand)
        {
            Company com = new Company();
            com.Brand = brand;
            return com;
        }
    }

    public static class CompanyUtil
    {
        public static string GetBrandsName(Brands brandName)
        {
            switch (brandName)
            {
                case Brands.AIGDirect:
                    return @"AIG Direct";

                case Brands.AmericanNational:
                    return @"American National";

                case Brands.Ethos:
                    return @"ETHOS";

                case Brands.FidelityLife:
                    return @"Fidelity Life";

                case Brands.HavenLife:
                    return @"Haven Life";

                case Brands.HealthIQ:
                    return @"Health IQ";

                case Brands.NationalFamily:
                    return @"National Family";

                case Brands.PolicyGenius:
                    return @"Policy Genius";

                case Brands.Trustage:
                    return @"Truestage";

                default:
                    return "";
            }
        }

        public static string GetCompanyImagePath(Brands name)
        {
            switch (name)
            {
                case Brands.AIGDirect:
                    return @"companyLogo/aigDirect.png";

                case Brands.AmericanNational:
                    return @"companyLogo/americanNational.png";

                case Brands.Ethos:
                    return @"companyLogo/ethos.png";

                case Brands.FidelityLife:
                    return @"companyLogo/fidelitylife.png";

                case Brands.HavenLife:
                    return @"companyLogo/HavenLife.png";

                case Brands.HealthIQ:
                    return @"companyLogo/HealthIQ.png";

                case Brands.NationalFamily:
                    return @"companyLogo/nationalFamily.png";

                case Brands.PolicyGenius:
                    return @"companyLogo/policyGenius.png";

                case Brands.Trustage:
                    return @"companyLogo/trustage.jpg";

                default:
                    return "";
            }
        }
    }


}
