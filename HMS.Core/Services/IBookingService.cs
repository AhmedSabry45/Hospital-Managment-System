using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Services
{
    public interface IBookingService
    {
        Task<string> GenerateBookingNumberAsync(CancellationToken cancellationToken = default);
    }
}
