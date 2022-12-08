using CQRS_Mediator.Commands.ObjectCommands.DeleteObjectCommnd;
using CQRS_Mediator.Models;
using CQRS_Mediator.Repositories;
using MediatR;

namespace CQRS_Mediator.Commands.ObjectCommands.CreateObjectCommnd
{
    public class DeleteObjectCommandHandler:IRequestHandler<DeleteObjectCommand,int>
    {
        private readonly ObjectRepository _objectRepository;

        public DeleteObjectCommandHandler(ObjectRepository objectRepository)
        {
            _objectRepository = objectRepository;
        }
        public async Task<int> Handle(DeleteObjectCommand request, CancellationToken cancellationToken)
        {
            //some operations
            var result =await _objectRepository.DeleteByIdAsync(request.Id);
            return result;
        }
    }
}
