using CQRS_Mediator.Commands.ObjectCommands.DeleteObjectCommnd;
using CQRS_Mediator.Repositories;
using MediatR;

namespace CQRS_Mediator.Commands.ObjectCommands.UpdateObjectCommand
{
    public class UpdateObjectCommandHandler:IRequestHandler<UpdateObjectCommand,bool>
    {

        private readonly ObjectRepository _objectRepository;

        public UpdateObjectCommandHandler(ObjectRepository objectRepository)
        {
            _objectRepository = objectRepository;
        }
        public async Task<bool> Handle(UpdateObjectCommand request, CancellationToken cancellationToken)
        {
            //some operations
            var result = await _objectRepository.UpdateAsync(request.Id,request.Model);
            return result;
        }
    }
}
