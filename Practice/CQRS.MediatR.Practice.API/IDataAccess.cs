namespace CQRS.MediatR.Practice.API
{
    public interface IDataAccess
    {
        List<Employee> GetEmployees();
        Employee AddEmployee(string name, string designation);
    }
}
