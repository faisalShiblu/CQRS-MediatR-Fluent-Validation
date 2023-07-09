using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Console.Models
{
    public class Person
    {
        public List<string> AddressLines { get; set; } = new List<string>();
    }

    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleForEach(x => x.AddressLines).NotNull().NotEmpty().WithMessage("Address {CollectionIndex} is required.");
        }
    }
}
