using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DBSMobile.Core;

namespace DBSMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page_ListviewTest : ContentPage
	{
		public Page_ListviewTest ()
		{
			InitializeComponent ();
            this.productsListView.ItemsSource = TestUtil.GetProducts();
        }

        public void ItemTabbed(EventArgs e)
        {
            PolicyProduct pp = (PolicyProduct)this.productsListView.SelectedItem;

            StringBuilder sbuf = new StringBuilder();
            sbuf.AppendLine(string.Format("{0} {1}", pp.CompanyImagePath, pp.CompanyImage.IsVisible));
            
            DisplayAlert("Alert", sbuf.ToString(), "OK");
        }



    }

    
}