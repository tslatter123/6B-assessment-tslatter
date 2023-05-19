using SixBAssessmentTSlatter.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace SixBAssessmentTSlatter.Client.ViewModels
{
    public class AddBookingViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DayFlexibilityEnum Flexibility { get; set; }

        [Required]
        public VehicleSizeEnum VehicleSize { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
