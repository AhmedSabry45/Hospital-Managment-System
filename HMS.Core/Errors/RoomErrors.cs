using HMS.Domain.Abstractions;
using Microsoft.AspNetCore.Http;

namespace HMS.Domain.Errors
{
    public class RoomErrors
    {
        public static readonly Error RoomNotFounded
           = new("Room.NotFounded", "The Room With this Id is Not Founded", StatusCodes.Status404NotFound);

        public static readonly Error RoomNotAvailable
          = new("Room.NotAvailable", "The Room With this Id is Not Available Now", StatusCodes.Status409Conflict);
    }
}
