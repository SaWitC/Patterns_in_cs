using CQRS_Mediator.Commands.ObjectCommands.CreateObjectCommnd;
using CQRS_Mediator.Commands.ObjectCommands.DeleteObjectCommnd;
using CQRS_Mediator.Commands.ObjectCommands.UpdateObjectCommand;
using CQRS_Mediator.Models;
using CQRS_Mediator.Queries.GetByIdQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS_Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ObjectController(IMediator mediator)
        {
            _mediator=mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var query = new GetByIdQuery();
            query.Id = id;
            var res= await _mediator.Send(query);
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateObjectCommand command)
        {
            var res =await _mediator.Send(command);
            return Ok(res);
        }

        [HttpPost("{id}")]
        [Route("Update")]
        public async Task<IActionResult> Update(string id,ObjectModel model)
        {
            var command = new UpdateObjectCommand();
            command.Id = id;
            command.Model = model;
            var res =await _mediator.Send(command);
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteObjectCommand();
            command.Id = id;
            var res = await _mediator.Send(command);
            return Ok(res);
        }
    }
}
