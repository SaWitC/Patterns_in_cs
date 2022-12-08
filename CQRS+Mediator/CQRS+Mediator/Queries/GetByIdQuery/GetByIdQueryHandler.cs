using CQRS_Mediator.Models;
using CQRS_Mediator.Repositories;
using MediatR;

namespace CQRS_Mediator.Queries.GetByIdQuery
{
    public class GetByIdQueryHandler:IRequestHandler<GetByIdQuery,ObjectModel>
    {
        private readonly ObjectRepository _objectRepository;
        public GetByIdQueryHandler( ObjectRepository _objectRepository)
        {
            _objectRepository = _objectRepository;
        }
        public async Task<ObjectModel> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            return await _objectRepository.GetByIdAsync(request.Id);
        }
    }
}
