using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Console.Models
{
    public class Address
    {
        public string Line1 { get; set; } = string.Empty;
        public string Line2 { get; set; } = string.Empty;
        public string Town { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Postcode { get; set; } = string.Empty;
    }

    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.Postcode).NotNull().NotEmpty();
            RuleFor(address => address.Line1).NotNull().NotEmpty();
            RuleFor(address => address.Town).NotNull().NotEmpty();
        }
    }
}
