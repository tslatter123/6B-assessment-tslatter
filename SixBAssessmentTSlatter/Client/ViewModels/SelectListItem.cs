namespace SixBAssessmentTSlatter.Client.ViewModels
{
    public class SelectListItem
    {
        public string Value { get; set; }
        public string DisplayText { get; set; }
        public bool IsSelected { get; set; }

        public SelectListItem(string value, string text, bool isSelected)
        {
            Value = value;
            DisplayText = text;
            IsSelected = isSelected;
        }
    }
}
