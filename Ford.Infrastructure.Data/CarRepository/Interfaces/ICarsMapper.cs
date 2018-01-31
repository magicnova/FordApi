using System.Collections.Generic;
using Ford.Domain;
using Ford.Infrastructure.Data.Models;

namespace Ford.Infrastructure.Data.CarRepository.Interfaces
{
    public interface ICarsMapper
    {
        CarSchema MapDomainToSchema(Car car);
        Car MapSchemaToDomain(CarSchema carSchema);
        IList<Car> MapSchemaToDomain(IList<CarSchema> carSchema);
    }
}