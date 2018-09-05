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
        List<string> Answer_Gender = new List<string>();
        List<string> Answer_YesNo = new List<string>();
        List<string> Answer_citizenship = new List<string>();

        public Page_TableTest ()
		{
            InitializeComponent ();
            Answer_YesNo.Add("Yes");
            Answer_YesNo.Add("No");

            SpouseRGroup.ItemsSource = Answer_YesNo;

            Answer_citizenship.Add("Citizen/Permanent Resident");
            Answer_citizenship.Add("Outside US");

            CitizenshipRGroup.ItemsSource = Answer_citizenship;

            Answer_Gender.Add("Male");
            Answer_Gender.Add("Female");
            GenderRGroup.ItemsSource = Answer_Gender;

        }

        async public void OnButClicked(EventArgs e)
        {
            await this.Navigation.PushAsync(new Page_SeondTest());
        }

    }
}