using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0064;


namespace R5T.D0085
{
    [ServiceDefinitionMarker]
    public interface IServicesConfigurer : IServiceDefinition
    {
        Task ConfigureServices(IServiceCollection services);
    }
}
