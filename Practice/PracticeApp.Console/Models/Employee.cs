using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Console.Models
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;

    }

    public class EmployeeValidation : AbstractValidator<Employee>
    {

        public EmployeeValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Employee Name is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Employee Email is required")
                                .EmailAddress().WithMessage("Email Address is not correct");
            RuleFor(x => x.DOB).NotEmpty().WithMessage("Employee DOB is required")
                            .Must(Validate_Age).WithMessage("Age Must be 18 or Greater");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Employee Password is required")
                        .Must(PAssword_Length).WithMessage("Password Length must be equal or greater than 2");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirm Password is required");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Confirm Password Don't Match");
        }

        private bool PAssword_Length(string pass_)
        {
            return pass_.Length >= 2;
        }

        private bool Validate_Age(DateTime Age_)
        {
            DateTime Current = DateTime.Today;
            int age = Current.Year - Convert.ToDateTime(Age_).Year;

            return age >= 18;
        }
    }
}
