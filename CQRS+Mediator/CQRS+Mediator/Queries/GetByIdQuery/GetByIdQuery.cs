using CQRS_Mediator.Models;
using MediatR;

namespace CQRS_Mediator.Queries.GetByIdQuery
{
    public class GetByIdQuery:IRequest<ObjectModel>
    {
        public string Id { get; set; }
    }
}
