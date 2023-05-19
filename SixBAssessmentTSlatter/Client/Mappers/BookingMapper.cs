using SixBAssessmentTSlatter.Client.Interfaces.Mappers;
using SixBAssessmentTSlatter.Client.ViewModels;
using SixBAssessmentTSlatter.Shared.Models;

namespace SixBAssessmentTSlatter.Client.Mappers
{
    public class BookingMapper : IBookingMapper
    {
        public Booking Map(BookingViewModel viewModel)
        {
            return new Booking
            {
                Id = viewModel.ID,
                Name = viewModel.Name,
                Date = viewModel.Date,
                Flexibility = viewModel.Flexibility,
                VehicleSize = viewModel.VehicleSize,
                ContactNumber = viewModel.ContactNumber,
                Email = viewModel.Email,
                IsApproved = viewModel.IsApproved
            };
        }

        public Booking Map(AddBookingViewModel viewModel)
        {
            return new Booking
            {
                Name = viewModel.Name,
                Date = viewModel.Date,
                Flexibility = viewModel.Flexibility,
                VehicleSize = viewModel.VehicleSize,
                ContactNumber = viewModel.ContactNumber,
                Email = viewModel.Email,
                IsApproved = false
            };

        }
    }
}
