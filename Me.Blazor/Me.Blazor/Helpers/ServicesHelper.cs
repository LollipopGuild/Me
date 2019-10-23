using Microsoft.Extensions.DependencyInjection;

namespace Me.Blazor.Helpers
{
    public static class ServicesHelper
    {
        public static void ConfigureCommonServices(IServiceCollection services)
        {
            //Add services shared between multiples project here
            services.AddBlazorMobileNativeServices<Startup>();
        }
    }
}
