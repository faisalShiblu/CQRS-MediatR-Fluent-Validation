using MediatR;

namespace CQRS.MediatR.Practice.API.Queries
{
    public record GetEmployeeByIdQuery(int Id) : IRequest<Employee>
    {
    }
}
