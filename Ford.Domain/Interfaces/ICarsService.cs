using System.Collections.Generic;

namespace Ford.Domain.Interfaces
{
    public interface ICarsService
    {
        void Create(Car car);
        IList<Car> GetAll();
        void Update(Car car);
        IList<Car> GetByModel(string model);
        IList<Car> GetByGearBox(string gearBox);
        IList<Car> GetByMotor(string motor);
        IList<Car> GetByYear(int year);
        Car GetById(string id);
        void Delete(string id);
    }
}