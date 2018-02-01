using Ford.Domain.Interfaces;
using Ford.Infrastructure.Data.CarRepository;
using Ford.Infrastructure.Data.CarRepository.Interfaces;
using Ford.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ford.IoC
{
    public class Container
    {
        public void Module(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICarsService, CarsService>();
            services.AddTransient<ICarsRepository, CarsRepository>();
            services.AddTransient<ICarsMapper, CarsMapper>();
            services.AddTransient<IValidator, Validator>();
        }
    }
}