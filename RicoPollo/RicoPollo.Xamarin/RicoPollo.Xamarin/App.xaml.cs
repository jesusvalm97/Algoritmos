using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RicoPollo.Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = new OKHOSTING.UI.Xamarin.Forms.Page();

            var main = new RicoPollo.UI.Main();
            main.Page = page;

            MainPage = page;

            main.Start();
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
