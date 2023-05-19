using SixBAssessmentTSlatter.Client.ViewModels;
using SixBAssessmentTSlatter.Shared.Models;

namespace SixBAssessmentTSlatter.Client.Interfaces.Mappers
{
    public interface IBookingMapper
    {
        public Booking Map(BookingViewModel viewModel);
        public Booking Map(AddBookingViewModel viewModel);
    }
}
