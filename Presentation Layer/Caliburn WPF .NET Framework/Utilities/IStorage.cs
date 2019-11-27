using System.Collections.Generic;
using System.Collections.ObjectModel;
using Service.WPF.Models.Interfaces;

namespace Service.WPF.Utilities
{
    public interface IStorage
    {
        List<INavBarItemModel> NavBarItems { get; set; }
    }
}