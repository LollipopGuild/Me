using System;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ReactiveUI;
using Splat;

namespace Me.Forms
{
    public partial class App : Application
    {
        public App()
        {
            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());

            InitializeComponent();

            MainPage = new MeView();
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
