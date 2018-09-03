using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBSMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page_TableTest : ContentPage
	{
		public Page_TableTest ()
		{
			InitializeComponent ();
		}

        async public void OnButClicked(EventArgs e)
        {
            await this.Navigation.PushAsync(new Page_SeondTest());
        }

    }
}