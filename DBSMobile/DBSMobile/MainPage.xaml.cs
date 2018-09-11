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

        async public void Clicked_TableTest(EventArgs e)
        {
            Page_TableTest tableTest = new Page_TableTest();
            
            await this.Navigation.PushAsync(tableTest);
            //App.Current.MainPage = new NavigationPage();
            //Application.Current.MainPage.Navigation.PushAsync(tableTest);
        }

        async public void Clicked_ListviewTest(EventArgs e)
        {
            Page_ListviewTest lt = new Page_ListviewTest();
            await this.Navigation.PushAsync(lt, true);
        }

        public void Clicked_CarouselTest(EventArgs e)
        {

        }
	}
}
