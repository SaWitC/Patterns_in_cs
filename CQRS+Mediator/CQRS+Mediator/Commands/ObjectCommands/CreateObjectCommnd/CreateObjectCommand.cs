using CQRS_Mediator.Models;
using MediatR;

namespace CQRS_Mediator.Commands.ObjectCommands.CreateObjectCommnd
{
    public class CreateObjectCommand:IRequest<ObjectModel>
    {
    public ObjectModel Model { get; set; }
    }
}
