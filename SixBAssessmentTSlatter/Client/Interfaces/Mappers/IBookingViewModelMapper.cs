using SixBAssessmentTSlatter.Client.ViewModels;
using SixBAssessmentTSlatter.Shared.Models;

namespace SixBAssessmentTSlatter.Shared.Interfaces.Mappers
{
    public interface IBookingViewModelMapper
    {
        public abstract BookingViewModel Map(Booking booking);
    }
}
