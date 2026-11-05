using System.ComponentModel.DataAnnotations;

class ValidateDate : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {

        if(value is DateTime dateValue)
        {
            if (dateValue < DateTime.UtcNow)
            {
                return new ValidationResult("You cant set event date in the past!");
            }

            
        }

            return ValidationResult.Success;

    }



    
}