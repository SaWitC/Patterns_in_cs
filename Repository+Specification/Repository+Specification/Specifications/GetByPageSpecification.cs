using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace Repository_Specification.Specifications
{
    public class GetByPageSpecification<T>:Specification<T>
    {
        public GetByPageSpecification(int page, int size)
        {
            Query.Skip(page * size).Take(size);
        }
    }
}
