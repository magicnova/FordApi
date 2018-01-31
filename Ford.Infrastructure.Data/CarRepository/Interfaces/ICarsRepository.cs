using Ford.Domain;

namespace Ford.Infrastructure.Data.CarRepository.Interfaces
{
    public interface ICarsRepository
    {
        void Create(Car car);
    }
}