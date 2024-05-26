using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PersonalInfoPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
