using SixBAssessmentTSlatter.Shared.Interfaces.Mappers;
using SixBAssessmentTSlatter.Client.ViewModels;
using SixBAssessmentTSlatter.Shared.Models;

namespace SixBAssessmentTSlatter.Client.Mappers
{
    public class BookingViewModelMapper : IBookingViewModelMapper
    {
        public BookingViewModel Map(Booking booking)
        {
            if (booking.Id == null)
            {
                throw new SystemException("Booking ID cannot be null");
            }

            return new BookingViewModel
            {
                ID = booking.Id,
                Name = booking.Name,
                Date = booking.Date,
                Flexibility = booking.Flexibility,
                VehicleSize = booking.VehicleSize,
                ContactNumber = booking.ContactNumber,
                Email = booking.Email,
                IsApproved = booking.IsApproved
            };
        }
    }
}
