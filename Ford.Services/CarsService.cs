using System.Collections.Generic;
using Ford.Domain;
using Ford.Domain.Interfaces;
using Ford.Infrastructure.Data.CarRepository.Interfaces;

namespace Ford.Services
{
    public class CarsService : ICarsService
    {
        private readonly ICarsRepository _carsRepository;
        private readonly IValidator _validator;

        public CarsService(ICarsRepository carsRepository, IValidator validator)
        {
            _carsRepository = carsRepository;
            _validator = validator;
        }

        public void Create(Car car)
        {
            _validator.ValidateCreationFieldsAreFilled(car);
            _carsRepository.Create(car);
        }

        public IList<Car> GetAll()
        {
            return _carsRepository.GetAll();
        }

        public void Update(Car car)
        {
            _validator.ValidateUpdateFieldsAreFilled(car);
            _carsRepository.Update(car);
        }

        public IList<Car> GetByModel(string model)
        {
            return _carsRepository.GetCollectionBy("Model", model);
        }

        public IList<Car> GetByGearBox(string gearBox)
        {
            return _carsRepository.GetCollectionBy("GearBox", gearBox);
        }

        public IList<Car> GetByMotor(string motor)
        {
            return _carsRepository.GetCollectionBy("Motor", motor);
        }

        public IList<Car> GetByYear(int year)
        {
            return _carsRepository.GetCollectionBy("Year", year.ToString());
        }

        public Car GetById(string id)
        {
            return _carsRepository.GetById(id);
        }

        public void Delete(string id)
        {
            _validator.ValidateDeleteFieldsAreFilled(id);
            _carsRepository.Delete(id);
        }
    }
}