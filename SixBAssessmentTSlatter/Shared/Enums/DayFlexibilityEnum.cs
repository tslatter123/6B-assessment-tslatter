using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBAssessmentTSlatter.Shared.Enums
{
    public enum DayFlexibilityEnum
    {
        [Description("+/- 1 Day")]
        OneDay = 0,
        [Description("+/- 2 Days")]
        TwoDays = 1,
        [Description("+/- 3 Days")]
        ThreeDays = 2,
    }
}
