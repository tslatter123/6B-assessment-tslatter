using SixBAssessmentTSlatter.Client.Interfaces;

namespace SixBAssessmentTSlatter.Client.Services
{
    public class BookingService : IBookingService
    {
        private readonly IHttpClientFactory _clientFactory;

        public BookingService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
    }
}
