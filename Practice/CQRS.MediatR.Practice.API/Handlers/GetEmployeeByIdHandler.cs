using CQRS.MediatR.Practice.API.Queries;
using MediatR;

namespace CQRS.MediatR.Practice.API.Handlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IMediator _mediator;
        public GetEmployeeByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employees = await _mediator.Send(new GetEmployeeListQuery());
            var searchedEmployee = employees.FirstOrDefault(s => s.Id == request.Id);
            return searchedEmployee;
        }
    }
}
