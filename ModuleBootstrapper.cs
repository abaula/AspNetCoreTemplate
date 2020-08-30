using AspNetCoreTemplate.Services;
using AspNetCoreTemplate.Services.Abstrations;
using Autofac;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreTemplate.WebApi
{
    public static class ModuleBootstrapper
    {
        public static void Configure(IConfiguration configuration, ContainerBuilder container)
        {
            container.RegisterType<Service>().As<IService>();
        }
    }
}