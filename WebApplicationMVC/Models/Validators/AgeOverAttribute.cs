using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace WebApplicationMVC.Models.Validators
{
    public class AgeOver : ValidationAttribute
    {
        public int MinAge { get; }
        public AgeOver(int minAge) 
        {
            MinAge = minAge;
        }
        public string GetErrorMessage() => $"Wiek musi być powyżej {MinAge}";

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            var member = (Member)validationContext.ObjectInstance;
            if (member.Age < MinAge)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
    }
}