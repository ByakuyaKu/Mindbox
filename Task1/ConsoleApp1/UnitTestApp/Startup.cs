using Microsoft.Extensions.DependencyInjection;

namespace UnitTestApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAreaLib, AreaLib>();
        }
    }
}
