using HMS.Domain.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Errors
{
    public static class InsuranceErrors
    {
        
        public static readonly Error FailedToAdd
            = new("Insurance.FailedToAdd", "An Error while Adding Insurance", StatusCodes.Status400BadRequest);

        public static readonly Error FailedToUpdate
            = new("Insurance.FailedToUpdate", "An Error while Update Insurance", StatusCodes.Status400BadRequest);

        public static readonly Error InsuranceNotFounded
            = new("Insurance.NotFounded", "The Insurance With this Id is Not Founded", StatusCodes.Status404NotFound);
    }
}
