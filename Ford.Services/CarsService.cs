using Ford.Domain;
using Ford.Domain.Interfaces;
using Ford.Infrastructure.Data.CarRepository.Interfaces;

namespace Ford.Services
{
    public class CarsService :ICarsService
    {
        private readonly ICarsRepository _carsRepository;

        public CarsService(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public void Create(Car car)
        {
            _carsRepository.Create(car);
        }
    }
}