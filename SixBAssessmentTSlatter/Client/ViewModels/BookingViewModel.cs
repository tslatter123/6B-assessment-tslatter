﻿using SixBAssessmentTSlatter.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace SixBAssessmentTSlatter.Client.ViewModels
{
    public class BookingViewModel
    {
        [Required]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now.Date;

        [Required]
        public DayFlexibilityEnum Flexibility { get; set; } = DayFlexibilityEnum.OneDay;

        [Required]
        public VehicleSizeEnum VehicleSize { get; set; } = VehicleSizeEnum.Small;

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public bool IsApproved { get; set; }
    }
}
