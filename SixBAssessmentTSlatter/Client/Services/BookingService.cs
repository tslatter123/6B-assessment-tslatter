using SixBAssessmentTSlatter.Client.Interfaces.Mappers;
using SixBAssessmentTSlatter.Client.Interfaces.Services;
using SixBAssessmentTSlatter.Client.ViewModels;
using SixBAssessmentTSlatter.Shared.Models;
using System.Net.Http.Json;

namespace SixBAssessmentTSlatter.Client.Services
{
    public class BookingService : IBookingService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IBookingMapper _bookingMapper;

        public BookingService(IHttpClientFactory clientFactory, IBookingMapper bookingMapper)
        {
            _clientFactory = clientFactory;
            _bookingMapper = bookingMapper;
        }

        public async Task AddBooking(AddBookingViewModel viewModel)
        {
            Booking newBooking = _bookingMapper.Map(viewModel);
            HttpClient client = _clientFactory.CreateClient("public");

            var result = await client.PostAsJsonAsync("api/AddBooking", newBooking);

            if (!result.IsSuccessStatusCode)
            {
                throw new SystemException($"{Convert.ToInt32(result.StatusCode)}: {result.StatusCode}");
            }
        }
    }
}
