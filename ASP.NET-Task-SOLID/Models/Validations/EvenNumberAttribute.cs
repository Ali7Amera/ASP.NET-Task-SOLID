using System.ComponentModel.DataAnnotations;

namespace TaskProject.Validations
{
    public class EvenNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            int number = (int)value;

            if (number % 2 == 0)
                return ValidationResult.Success;

            return new ValidationResult("Number must be even");
        }
    }
}
