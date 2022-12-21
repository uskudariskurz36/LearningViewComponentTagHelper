namespace LearningViewComponentTagHelper.Models
{
    public class AddressInfoPartialModel
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Title { get; set; }
        public Colors PanelColor { get; set; }
    }

    public enum Colors
    {
        none,
        danger,
        dark,
        info,
        light,
        primary,
        secondary,
        success,
        warning,
    }
}
