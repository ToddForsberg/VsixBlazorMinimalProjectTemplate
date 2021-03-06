using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMinimalProjectTemplate
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
        }

        public void Configure(IBlazorApplicationBuilder blazorApplicationBuilder)
        {
            blazorApplicationBuilder.AddComponent<MyApp>("myApp");
        }
    }
}
