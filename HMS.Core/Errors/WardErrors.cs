using HMS.Domain.Abstractions;
using Microsoft.AspNetCore.Http;

namespace HMS.Domain.Errors
{
    public class WardErrors
    {
        public static readonly Error WardNotFounded
           = new("Ward.NotFounded", "The Ward With this Id is Not Founded", StatusCodes.Status404NotFound);
    }
}
