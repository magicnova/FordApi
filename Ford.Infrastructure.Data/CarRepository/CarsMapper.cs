using System;
using System.Collections.Generic;
using System.Linq;
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
                Id = carSchema.Id.ToString(),
                Active = carSchema.Active,
                GearBox = carSchema.GearBox,
                Model = carSchema.Model,
                Motor = carSchema.Motor,
                Year = carSchema.Year
            };
        }

        public IList<Car> MapSchemaToDomain(IList<CarSchema> carSchema)
        {
            return carSchema.Select(schema =>
                new Car
                {
                    Id = schema.Id.ToString(),
                    Active = schema.Active,
                    GearBox = schema.GearBox,
                    Model = schema.Model,
                    Motor = schema.Motor,
                    Year = schema.Year
                }
            ).ToList();
        }
    }
}