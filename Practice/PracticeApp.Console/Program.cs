using FluentValidation;
using FluentValidation.Results;
using PracticeApp.Console.Models;


//Address address = new Address()
//{
//    Country = "",
//    Line1 = "",
//    Line2 = "",
//    Postcode = "",
//    Town = ""
//};

//Customer customer = new Customer()
//{
//    Surname = " ",
//    Address = address,
//    Discount = 0,
//    Forename = " ",
//    Id = 0
//};
//CustomerValidator validator = new CustomerValidator();

//ValidationResult results = validator.Validate(customer);


//Person person = new Person()
//{
//    AddressLines = null
//};
//var validator = new PersonValidator();
//ValidationResult results = validator.Validate(person);


Employee employee = new Employee
{
    Name = "Shiblu",
    Email = "shiblu@gmail.com",
    DOB = Convert.ToDateTime("1990-01-01"),
    Password = "C1",
    ConfirmPassword= "C1"
};

var validator = new EmployeeValidation();
ValidationResult results = validator.Validate(employee);

if (!results.IsValid)
{
    foreach (var failure in results.Errors)
    {
        Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
    }
}