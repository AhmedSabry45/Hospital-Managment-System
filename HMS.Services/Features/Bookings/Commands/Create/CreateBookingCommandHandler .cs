using HMS.Domain.Enums;
using HMS.Domain.Errors;
using HMS.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Application.Features.Bookings.Commands.Create
{
    class CreateBookingCommandHandler(IUnitOfWork unitOfWork, IBookingService bookingService) : IRequestHandler<CreateBookingCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IBookingService _bookingService = bookingService;

        public async Task<Result<int>> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var patient = await _unitOfWork.Repository<Patient>().GetByIdAsync(request.PatientId, cancellationToken);

            if (patient == null)
                return Result.Failure<int>(PatientErrors.PatientNotFounded);

            var room = await _unitOfWork.Repository<Room>().GetByIdAsync(request.RoomId, cancellationToken);

            if (room == null)
                return Result.Failure<int>(RoomErrors.RoomNotFounded);

            var ward = await _unitOfWork.Repository<Ward>().GetByIdAsync(request.WardId, cancellationToken);

            if (ward == null)
                return Result.Failure<int>(WardErrors.WardNotFounded);

            // Check Booking Conflicts
            var bookingRepository = _unitOfWork.Repository<Booking>();

            var hasConflicts = await bookingRepository.AnyAsync(
                b => b.RoomId == request.RoomId &&
                     b.Status != BookingStatus.Cancelled &&
                     (
                         (request.StartDate >= b.StartDate && request.StartDate < b.EndDate) ||
                         (request.EndDate > b.StartDate && request.EndDate <= b.EndDate) ||
                         (request.StartDate <= b.StartDate && request.EndDate >= b.EndDate)
                     ),
                cancellationToken
            );

            if (hasConflicts)
                return Result.Failure<int>(RoomErrors.RoomNotAvailable);

            try
            {

                var bookingNumber = await _bookingService.GenerateBookingNumberAsync(cancellationToken);

                var booking = request.Adapt<Booking>();

                booking.BookingNumber = bookingNumber;

                await bookingRepository.AddAsync(booking, cancellationToken);

                await _unitOfWork.CompleteAsync(cancellationToken);

                return Result.Success(booking.Id);
            }
            catch (Exception ex)
            {
                return Result.Failure<int>(BookingErrors.FailedToAdd);
            }
        }
    }
}

