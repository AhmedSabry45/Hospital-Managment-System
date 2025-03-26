using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Insurance.Commands.Delete
{
    public class DeleteInsuranceCategoryCommand(int id) : IRequest<Result>
    {
        public int Id { get; set; } = id;
    }
}
