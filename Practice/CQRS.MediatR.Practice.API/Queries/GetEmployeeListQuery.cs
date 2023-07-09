using MediatR;

namespace CQRS.MediatR.Practice.API.Queries
{
   public record GetEmployeeListQuery(): IRequest<List<Employee>>;
}
