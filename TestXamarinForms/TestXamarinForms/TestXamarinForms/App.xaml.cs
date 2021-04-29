using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = new OKHOSTING.UI.Xamarin.Forms.Page();
            page.App = new OKHOSTING.UI.App();

            MainPage = page;

            var firstPage = new TestXamarinForms.UI.Main();
            firstPage.Page = page;
            firstPage.Start();
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
