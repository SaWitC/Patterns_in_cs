using CQRS_Mediator.Commands.ObjectCommands.CreateObjectCommnd;
using CQRS_Mediator.Models;
using CQRS_Mediator.Repositories;
using MediatR;

namespace CQRS_Mediator.Commands.ObjectCommands.DeleteObjectCommnd
{
    public class DeleteObjectCommandHandler:IRequestHandler<CreateObjectCommand,ObjectModel>
    {
        private readonly ObjectRepository _objectRepository;

        public DeleteObjectCommandHandler(ObjectRepository objectRepository)
        {
            _objectRepository = objectRepository;
        }
        public async Task<ObjectModel> Handle(CreateObjectCommand request, CancellationToken cancellationToken)
        {
            //some operations
            var entity =await _objectRepository.CreateASync(request.Model);
            return entity.Entity;
        }
    }
}
