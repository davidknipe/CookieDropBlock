using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace CookieDropBlock
{
    [ModuleDependency(typeof(InitializationModule))]
    public class CookieDropBlockInit : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.ConfigurationComplete += (o, e) =>
            {
                var assembly = GetType().Assembly;
                var serviceCollection = context.Services;
                serviceCollection
                    .AddControllersWithViews()
                    .AddApplicationPart(assembly)
                    .AddRazorRuntimeCompilation(
                        options => 
                            options.FileProviders.Add(new EmbeddedFileProvider(assembly, "cookiedropblock"))
                            );

                serviceCollection.Configure<MvcRazorRuntimeCompilationOptions>(options =>
                {
                    options.FileProviders.Add(new EmbeddedFileProvider(assembly));
                });
            };
        }

        public void Initialize(InitializationEngine context) { }

        public void Uninitialize(InitializationEngine context) { }
    }
}
