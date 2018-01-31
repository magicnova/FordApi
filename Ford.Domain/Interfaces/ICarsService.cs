using System.Collections.Generic;

namespace Ford.Domain.Interfaces
{
    public interface ICarsService
    {
        void Create(Car car);
        IList<Car> GetAll();
    }
}