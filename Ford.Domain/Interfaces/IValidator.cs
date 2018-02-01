namespace Ford.Domain.Interfaces
{
    public interface IValidator
    {
        void ValidateCreationFieldsAreFilled(Car car);
        void ValidateUpdateFieldsAreFilled(Car car);
    }
}