using SixBAssessmentTSlatter.Client.ViewModels;
using SixBAssessmentTSlatter.Shared.Models;

namespace BlazorPracticeApp.Shared.Interfaces.Mappers
{
    public interface IBookingViewModelMapper
    {
        public abstract BookingViewModel Map(Booking booking);
    }
}
