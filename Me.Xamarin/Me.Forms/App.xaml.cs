using System;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ReactiveUI;
using Splat;

using Me.Forms.Views;
using Me.ViewModels;

namespace Me.Forms
{
    public partial class App : Application
    {
        AppBootstrapper _Bootstrapper;

        public App()
        {
            _Bootstrapper = new AppBootstrapper();

            InitializeComponent();

            MainPage = new WalletView() { ViewModel = Locator.Current.GetService<WalletViewModel>() };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
