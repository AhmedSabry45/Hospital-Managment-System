using HMS.Domain.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Errors
{
    public static class PatientErrors
    {
        public static readonly Error InvalidGender
            = new("Patient.InvalidGender", "Gender must be 'Male' or 'Female'", StatusCodes.Status400BadRequest);

        public static readonly Error FailedToAdd
            = new("Patient.FailedToAdd", "An Error while Adding Patient", StatusCodes.Status400BadRequest);
        
        
        public static readonly Error PatientNotFounded
            = new("Patient.NotFounded", "The Patient With this Id is Not Founded", StatusCodes.Status404NotFound);
    }
}
