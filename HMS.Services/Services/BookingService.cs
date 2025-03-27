using HMS.Domain.Services;
using HMS.Infrastructure._Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Services
{
    public class BookingService(IUnitOfWork unitOfWork) : IBookingService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<string> GenerateBookingNumberAsync(CancellationToken cancellationToken = default)
        {
            var currentYear = DateTime.UtcNow.Year;
            var currentMonth = DateTime.UtcNow.Month;

            var lastBooking = await _unitOfWork.Repository<Booking>()
               .GetAllAsQueryable()
               .Where(b => b.BookingNumber.StartsWith($"{currentYear}{currentMonth:D2}"))
               .OrderByDescending(b => b.BookingNumber)
               .FirstOrDefaultAsync(cancellationToken);

            int sequence = 1;

            if (lastBooking != null)
            {
                var lastSequence = int.Parse(lastBooking.BookingNumber.Substring(6));
                sequence = lastSequence + 1;
            }

            return $"{currentYear}{currentMonth:D2}{sequence:D6}";
        }
    }
}
