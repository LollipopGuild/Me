using BlazorMobile.Common;
using BlazorMobile.Components;
using BlazorMobile.Services;

namespace Me.Forms
{
	public partial class App : BlazorApplication
    {
        public const string BlazorAppPackageName = "Me.Blazor.zip";

        public App()
        {
            InitializeComponent();

            WebApplicationFactory.SetHttpPort(8888);

            //Register Blazor application package resolver
            WebApplicationFactory.RegisterAppStreamResolver(() =>
            {
                //This app assembly
                var assembly = typeof(App).Assembly;

                //Name of our current Blazor package in this project, stored as an "Embedded Resource"
                //The file is resolved through AssemblyName.FolderAsNamespace.YourPackageNameFile

                //In this example, the result would be Me.Package.Me.Blazor.zip
                return assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Package.{BlazorAppPackageName}");
            });

            MainPage = new MainPage();
        }
    }
}
