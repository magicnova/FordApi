using System;
using Ford.Domain;
using Ford.Domain.Interfaces;

namespace Ford.Services
{
    public class Validator : IValidator
    {
        public void ValidateCreationFieldsAreFilled(Car car)
        {
            if ( string.IsNullOrEmpty(car.GearBox ) || string.IsNullOrEmpty(car.Model)
                                            || string.IsNullOrEmpty(car.Motor) || car.Year == 0)
                throw new Exception("All fields are required, except the id and active fields");
        }

        public void ValidateUpdateFieldsAreFilled(Car car)
        {
            if ( string.IsNullOrEmpty(car.GearBox ) || string.IsNullOrEmpty(car.Model)
                                                    || string.IsNullOrEmpty(car.Motor) || 
                                                    string.IsNullOrEmpty(car.Id) ||
                                                    car.Year == 0)
                throw new Exception("Id is required, except active field");
        }

        public void ValidateDeleteFieldsAreFilled(string id)
        {
            if (id == string.Empty) throw new Exception("Id is required");
        }
    }
}