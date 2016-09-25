using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace SalesPortal.Web.Infrastructure
{
    public class DefaultContainerFactory
    {
        public static IContainer Get(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);
            return builder.Build();
        }
    }
}