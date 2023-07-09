namespace CQRS.MediatR.Practice.API
{
    public class DataAccess : IDataAccess
    {
        private List<Employee> _employees = new List<Employee>();

        public DataAccess()
        {
            _employees.Add(new Employee { Id = 1, Name = "Faisal", Designation = "C" });
            _employees.Add(new Employee { Id = 2, Name = "Alam", Designation = "Q" });
            _employees.Add(new Employee { Id = 3, Name = "Shiblu", Designation = "R" });
            _employees.Add(new Employee { Id = 4, Name = "MFA", Designation = "S" });
        }

        public Employee AddEmployee(string name, string designation)
        {
            Employee employee = new Employee()
            {
                Designation = designation,
                Name = name,
                Id = _employees.Max(x => x.Id) + 1
            };
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
