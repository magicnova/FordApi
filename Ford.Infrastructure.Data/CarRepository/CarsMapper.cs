using System;
using System.Collections.Generic;
using System.Linq;
using Ford.Domain;
using Ford.Infrastructure.Data.CarRepository.Interfaces;
using Ford.Infrastructure.Data.Models;
using MongoDB.Bson;

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
                Year = car.Year,
                Id = !string.IsNullOrEmpty(car.Id)? ObjectId.Parse(car.Id) : ObjectId.Empty
            };
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