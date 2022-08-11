using System;
using ThursdayTry.Services;
using ThursdayTry.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThursdayTry
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
