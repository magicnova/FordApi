using Ford.Domain;
using Ford.Infrastructure.Data.CarRepository.Interfaces;
using Ford.Infrastructure.Data.Context.Interfaces;

namespace Ford.Infrastructure.Data.CarRepository
{
    public class CarsRepository :ICarsRepository
    {
        private readonly IFordContext _fordContext;

        public CarsRepository(IFordContext fordContext)
        {
            _fordContext = fordContext;
        }

        public void Create(Car car)
        {
            _fordContext.GetContext().GetCollection<Car>("Cars").InsertOne(car);
        }
    }
}