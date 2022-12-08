using CQRS_Mediator.Models;
using MediatR;

namespace CQRS_Mediator.Commands.ObjectCommands.UpdateObjectCommand
{
    public class UpdateObjectCommand:IRequest<bool>
    {
        public string Id { get; set; }
        public ObjectModel Model { get; set; }
    }
}
