using HMS.Domain.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Errors
{
    public class BookingErrors
    {
        public static readonly Error FailedToAdd
            = new("Booking.FailedToAdd", "An Error while Adding Booking", StatusCodes.Status400BadRequest);
    }
}
