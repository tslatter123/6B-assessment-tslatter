namespace SixBAssessmentTSlatter.Client.Interfaces.Services
{
    public interface IEnumService<TEnum>
    {
        public string GetDescription(TEnum value);
    }
}
