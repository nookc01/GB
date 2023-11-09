using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NOOKC01.Services;
using NOOKC01.Views;

namespace NOOKC01
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
