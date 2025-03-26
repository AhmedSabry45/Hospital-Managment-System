using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Insurance.Commands.Create
{
    public class CreateInsuranceCompanyCommand : IRequest<Result<int>>
    {
        public string Name { get; set; }
    }
}
