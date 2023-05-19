using SixBAssessmentTSlatter.Client.Interfaces.Services;
using SixBAssessmentTSlatter.Client.ViewModels;
using System.ComponentModel;
using System.Reflection;

namespace SixBAssessmentTSlatter.Client.Services
{
    public class EnumService<TEnum> : IEnumService<TEnum> where TEnum : Enum
    {
        public IEnumerable<SelectListItem> GetSelectList(TEnum? value)
        {
            return Enum.GetValues(typeof(TEnum)).Cast<TEnum>()
                .Select(x => new SelectListItem(x.ToString(), GetDescription(x), CheckValuesMatch(value, x)));
        }

        public string GetDescription(TEnum value)
        {
            FieldInfo? field = GetFieldInfo(value);

            if (field == null)
            {
                return value.ToString();
            }

            DescriptionAttribute[]? attributes = GetDescriptionAttributesArray(field);
            DescriptionAttribute? attribute = GetDescriptionAttribute(attributes);

            return attribute == null ? value.ToString() : attribute.Description;
        }

        private static FieldInfo? GetFieldInfo(TEnum value)
        {
            return typeof(TEnum).GetField(value.ToString());
        }

        private static DescriptionAttribute[]? GetDescriptionAttributesArray(FieldInfo field)
        {
            return field.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
        }

        private static DescriptionAttribute? GetDescriptionAttribute(DescriptionAttribute[]? attributes)
        {
            return attributes == null || !attributes.Any() ? null : attributes[0];
        }

        private static bool CheckValuesMatch(TEnum? value1, TEnum? value2)
        {
            return value1?.ToString() == value2?.ToString();
        }
    }
}
