using Ford.Domain;
using Ford.Infrastructure.Data.CarRepository.Interfaces;
using Ford.Infrastructure.Data.Context.Interfaces;
using Ford.Infrastructure.Data.Models;

namespace Ford.Infrastructure.Data.CarRepository
{
    public class CarsRepository :ICarsRepository
    {
        private readonly IFordContext _fordContext;
        private readonly ICarsMapper _carsMapper;
        public CarsRepository(IFordContext fordContext, ICarsMapper carsMapper)
        {
            _fordContext = fordContext;
            _carsMapper = carsMapper;
        }

        public void Create(Car car)
        {
            var carSchema = _carsMapper.MapDomainToSchema(car);
            _fordContext.GetContext().GetCollection<CarSchema>("Cars").InsertOne(carSchema);
        }
    }
}