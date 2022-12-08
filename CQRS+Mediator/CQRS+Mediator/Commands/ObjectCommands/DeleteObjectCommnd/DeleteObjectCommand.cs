using CQRS_Mediator.Models;
using MediatR;

namespace CQRS_Mediator.Commands.ObjectCommands.DeleteObjectCommnd
{
    public class DeleteObjectCommand:IRequest<int>
    {
        public string Id { get; set; }
    }
}
