using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Insurance.Queries.GetAll
{
    public class GetAllInsuranceCategoriesQuery : IRequest<Result<IReadOnlyList<InsuranceResponse>>> { }

}
