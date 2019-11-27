using Service.WPF.Models.Interfaces;

namespace Service.WPF.Models
{
    public class NavBarItemModel : INavBarItemModel
    {
        public string Text { get; set; }

        public NavBarItemModel(string text)
        {
            Text = text;
        }
    }
}