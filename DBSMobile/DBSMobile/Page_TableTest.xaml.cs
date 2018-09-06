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

        int curSectionNumber = 1;

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

            EnableSection(curSectionNumber);
        }

        public void EnableSection(int sectionNumber)
        {
            if(sectionNumber==1)
            {
                if (!this.MainTable.Root.Contains(section01))
                    this.MainTable.Root.Add(section01);

                if (this.MainTable.Root.Contains(section02))
                    this.MainTable.Root.Remove(section02);

                if (this.MainTable.Root.Contains(section03))
                    this.MainTable.Root.Remove(section03);
            }
            if (sectionNumber == 2)
            {
                if (!this.MainTable.Root.Contains(section02))
                    this.MainTable.Root.Add(section02);

                if (this.MainTable.Root.Contains(section01))
                    this.MainTable.Root.Remove(section01);

                if (this.MainTable.Root.Contains(section03))
                    this.MainTable.Root.Remove(section03);
            }
            if (sectionNumber == 3)
            {
                if (!this.MainTable.Root.Contains(section03))
                    this.MainTable.Root.Add(section03);

                if (this.MainTable.Root.Contains(section02))
                    this.MainTable.Root.Remove(section02);

                if (this.MainTable.Root.Contains(section01))
                    this.MainTable.Root.Remove(section01);
            }
        }

        async public void OnButClicked(EventArgs e)
        {
            await this.Navigation.PushAsync(new Page_SeondTest());
        }

        async public void PrevClicked(EventArgs e)
        {
            if (curSectionNumber > 1)
                curSectionNumber--;
            EnableSection(curSectionNumber);
        }

        async public void NextClicked(EventArgs e)
        {
            if (curSectionNumber < 3)
                curSectionNumber++;
            EnableSection(curSectionNumber);
        }

    }
}