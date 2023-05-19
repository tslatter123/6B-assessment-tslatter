using SixBAssessmentTSlatter.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBAssessmentTSlatter.Shared.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }

        public DayFlexibilityEnum Flexibility { get; set; }

        public VehicleSizeEnum VehicleSize { get; set; }

        public string ContactNumber { get; set; }
        public string Email { get; set; }
    }
}
