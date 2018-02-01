using System.Collections.Generic;
using Ford.Domain;

namespace Ford.Infrastructure.Data.CarRepository.Interfaces
{
    public interface ICarsRepository
    {
        void Create(Car car);
        void Update(Car car);
        IList<Car> GetAll();
        Car GetById(string id);
        IList<Car> GetCollectionBy(string dbField, string valueCondition);
        void Delete(string id);
    }
}