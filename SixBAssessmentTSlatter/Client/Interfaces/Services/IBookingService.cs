using SixBAssessmentTSlatter.Client.ViewModels;

namespace SixBAssessmentTSlatter.Client.Interfaces.Services
{
    public interface IBookingService
    {
        public abstract Task AddBooking(AddBookingViewModel viewModel);
    }
}
