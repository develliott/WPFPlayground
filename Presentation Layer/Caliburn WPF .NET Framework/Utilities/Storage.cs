using System.Collections.Generic;
using System.Collections.ObjectModel;
using Service.WPF.Models;
using Service.WPF.Models.Interfaces;

namespace Service.WPF.Utilities
{
    public class Storage : IStorage
    {
        private static List<INavBarItemModel> _navBarItems;
        public List<INavBarItemModel> NavBarItems
        {
            get
            {
                if (_navBarItems == null)
                {
                    _navBarItems = new List<INavBarItemModel>
                    {
                        new NavBarItemModel("Main"), new NavBarItemModel("Second"), new NavBarItemModel("Third")
                    };
                }

                return _navBarItems;
            }
            set => _navBarItems = value;
        }
    }
}