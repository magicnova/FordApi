using System;
using Ford.Domain;
using Ford.Infrastructure.Data.CarRepository.Interfaces;
using Ford.Infrastructure.Data.Models;

namespace Ford.Infrastructure.Data.CarRepository
{
    public class CarsMapper :ICarsMapper
    {
        public CarSchema MapDomainToSchema(Car car)
        {
            return new CarSchema
            {
                Active = car.Active,
                CreatedAt = DateTime.Now,
                UpdatedAt = null,
                GearBox = car.GearBox,
                Model = car.Model,
                Motor = car.Motor,
                Year = car.Year
            };
        }

        public CarSchema MapDomainToSchema(Car car, CarSchema carSchema)
        {
            carSchema.Active = car.Active;
            carSchema.UpdatedAt = DateTime.Now;
            carSchema.GearBox = car.GearBox;
            carSchema.Model = car.Model;
            carSchema.Motor = car.Motor;
            carSchema.Year = car.Year;

            return carSchema;
        }

        public Car MapSchemaToDomain(CarSchema carSchema)
        {
            return new Car
            {
                Active = carSchema.Active,
                GearBox = carSchema.GearBox,
                Model = carSchema.Model,
                Motor = carSchema.Motor,
                Year = carSchema.Year
            };
        }
    }
}