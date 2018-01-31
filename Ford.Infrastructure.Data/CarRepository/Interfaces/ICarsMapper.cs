using Ford.Domain;
using Ford.Infrastructure.Data.Models;

namespace Ford.Infrastructure.Data.CarRepository.Interfaces
{
    public interface ICarsMapper
    {
        CarSchema MapDomainToSchema(Car car);
        CarSchema MapDomainToSchema(Car car,CarSchema carSchema);
        Car MapSchemaToDomain(CarSchema carSchema);
    }
}