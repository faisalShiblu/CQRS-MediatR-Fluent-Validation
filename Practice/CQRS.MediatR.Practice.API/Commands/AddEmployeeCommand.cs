using MediatR;

namespace CQRS.MediatR.Practice.API.Commands
{
    public record AddEmployeeCommand (string name, string designation):IRequest<Employee>;
}
