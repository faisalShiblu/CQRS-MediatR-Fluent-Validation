using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Console.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Surname { get; set; } = string.Empty;
        public string Forename { get; set; } = string.Empty;
        public decimal Discount { get; set; }
       public Address Address { get; set; } = new Address();
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Surname).NotNull().NotEmpty().NotEqual("foo");
            RuleFor(customer => customer.Address).SetValidator(new AddressValidator());
        }
    }

}
