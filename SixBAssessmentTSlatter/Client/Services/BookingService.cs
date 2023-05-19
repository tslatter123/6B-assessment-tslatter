using BlazorPracticeApp.Shared.Interfaces.Mappers;
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
        private readonly IBookingViewModelMapper _bookingViewModelMapper;

        public BookingService(IHttpClientFactory clientFactory, IBookingMapper bookingMapper, IBookingViewModelMapper bookingViewModelMapper)
        {
            _clientFactory = clientFactory;
            _bookingMapper = bookingMapper;
            _bookingViewModelMapper = bookingViewModelMapper;
        }

        public async Task<IEnumerable<BookingViewModel>> GetAllBookings()
        {
            var client = _clientFactory.CreateClient("private");
            var result = await client.GetAsync($"api/Bookings");

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"{Convert.ToInt32(result.StatusCode)}: {result.StatusCode}");
            }

            IEnumerable<Booking>? bookings = await result.Content.ReadFromJsonAsync<IEnumerable<Booking>>();

            if (bookings == null)
            {
                throw new Exception("Bookings not found");
            }

            IEnumerable<BookingViewModel> viewModel = bookings.Select(x => _bookingViewModelMapper.Map(x));

            return viewModel;
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

        public async Task<Booking> EditBooking(BookingViewModel viewModel)
        {
            Booking booking = _bookingMapper.Map(viewModel);
            var client = _clientFactory.CreateClient("private");
            var result = await client.PostAsJsonAsync("api/Bookings", booking);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"{Convert.ToInt32(result.StatusCode)}: {result.StatusCode}");
            }

            return booking;
        }

        public async Task ApproveBooking(BookingViewModel viewModel)
        {
            if (!viewModel.IsApproved)
            {
                viewModel.IsApproved = true;
            }

            await EditBooking(viewModel);
        }

        public async Task DeleteBooking(string id)
        {
            var client = _clientFactory.CreateClient("private");
            var result = await client.DeleteAsync($"api/Bookings?id={id}");

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"{Convert.ToInt32(result.StatusCode)}: {result.StatusCode}");
            }
        }
    }
}
