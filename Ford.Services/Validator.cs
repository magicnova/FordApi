using System;
using Ford.Domain;
using Ford.Domain.Interfaces;

namespace Ford.Services
{
    public class Validator : IValidator
    {
        public void ValidateCreationFieldsAreFilled(Car car)
        {
            if (car.GearBox == string.Empty || car.Model == string.Empty
                                            || car.Motor == string.Empty || car.Year == 0)
            {
                throw new Exception("All fields are required");
            }
        }

        public void ValidateUpdateFieldsAreFilled(Car car)
        {
            if (car.Id == string.Empty)
            {
                throw new Exception("Id is required");
            }
        }
    }
}