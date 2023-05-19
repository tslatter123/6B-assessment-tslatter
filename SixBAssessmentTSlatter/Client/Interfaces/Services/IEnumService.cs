using SixBAssessmentTSlatter.Client.ViewModels;

namespace SixBAssessmentTSlatter.Client.Interfaces.Services
{
    public interface IEnumService<TEnum>
    {
        public IEnumerable<SelectListItem> GetSelectList(TEnum? value);
        public string GetDescription(TEnum value);
    }
}
