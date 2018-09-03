using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DBSMobile
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }

        async public void ButClicked(EventArgs e)
        {
            Page_TableTest tableTest = new Page_TableTest();
            
            await this.Navigation.PushAsync(tableTest);
            //App.Current.MainPage = new NavigationPage();
            //Application.Current.MainPage.Navigation.PushAsync(tableTest);
        }
	}
}
