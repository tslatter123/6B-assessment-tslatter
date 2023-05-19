using SixBAssessmentTSlatter.Client.ViewModels;
using SixBAssessmentTSlatter.Shared.Models;

namespace SixBAssessmentTSlatter.Client.Interfaces.Services
{
    public interface IBookingService
    {
        public abstract Task<IEnumerable<BookingViewModel>> GetAllBookings();
        public abstract Task AddBooking(AddBookingViewModel viewModel);
        public abstract Task<Booking> EditBooking(BookingViewModel viewModel);
        public abstract Task ApproveBooking(BookingViewModel viewModel);
        public abstract Task DeleteBooking(string id);
    }
}
