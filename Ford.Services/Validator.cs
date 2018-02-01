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
                throw new Exception("All fields are required, except the id and active fields");
            }
        }

        public void ValidateUpdateFieldsAreFilled(Car car)
        {
            if (car.GearBox == string.Empty || car.Model == string.Empty
                                            || car.Motor == string.Empty || car.Year == 0||car.Id == string.Empty)
            {
                throw new Exception("Id is required, except active field");
            }
        }

        public void ValidateDeleteFieldsAreFilled(string id)
        {
            if (id == string.Empty)
            {
                throw new Exception("Id is required");
            }
        }
    }
}