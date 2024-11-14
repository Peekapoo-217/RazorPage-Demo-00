//using Microsoft.AspNetCore.Mvc;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel;
//using RazorPageWeb.Validators.Strategies;

//namespace RazorPageWeb.Validators
//{
//    public class CustomBirthDateAttribute : ValidationAttribute
//    {
//        private readonly IBirthDateValidationStrategy _validationStrategy;

//        public CustomBirthDateAttribute(Type strategyType)
//        {
//            if (!typeof(IBirthDateValidationStrategy).IsAssignableFrom(strategyType))
//            {
//                throw new ArgumentException("Invalid strategy type");
//            }
//            _validationStrategy = (IBirthDateValidationStrategy)Activator.CreateInstance(strategyType);
//        }

//        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
//        {
//            if(value is DateTime birthDate)
//            {
//                return _validationStrategy.Validate(birthDate);
//            }
//            return new ValidationResult("Invalid");
//        }
//    }
//}
