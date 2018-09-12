using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;

namespace DBSMobile.Core
{
    public class PolicyProduct
    {
        private Image _image = null;
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal MonthlyPayment { get; set; }
        public Company MyCompany { get; set; }
        public string CompanyName { get { return MyCompany.BrandName; }}
        public string CompanyImagePath { get { return MyCompany.LogoPath; } }
        public Image CompanyImage {
            get {
                if (this._image == null)
                {
                    _image = new Image() { Source = ImageSource.FromResource(MyCompany.LogoPath, typeof(PolicyProduct).GetTypeInfo().Assembly)};
                }
                return _image;
            }
        }


    }


}
