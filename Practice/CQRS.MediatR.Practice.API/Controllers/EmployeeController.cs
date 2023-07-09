using CQRS.MediatR.Practice.API.Commands;
using CQRS.MediatR.Practice.API.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.MediatR.Practice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await _mediator.Send(new GetEmployeeListQuery());
        }

        [HttpGet("{id}")]
        public async Task<Employee> Get(int id)
        {
            return await _mediator.Send(new GetEmployeeByIdQuery(id));
        }

        [HttpPost]
        public async Task<Employee> Post([FromBody] Employee employee)
        {
            return await _mediator.Send(new AddEmployeeCommand(employee.Name, employee.Designation));
        }

    }
}
