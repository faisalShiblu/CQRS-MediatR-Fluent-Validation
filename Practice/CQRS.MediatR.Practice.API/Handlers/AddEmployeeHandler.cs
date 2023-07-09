using CQRS.MediatR.Practice.API.Commands;
using MediatR;

namespace CQRS.MediatR.Practice.API.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {
        private readonly IDataAccess _dataAccess;
        public AddEmployeeHandler(IDataAccess dataAccess)
        {

            _dataAccess = dataAccess;

        }

        public Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.AddEmployee(request.name, request.designation));
        }
    }
}
