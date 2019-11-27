using System.Collections.ObjectModel;
using System.Linq;
using Caliburn.Micro;
using Service.WPF.Models.Interfaces;
using Service.WPF.Utilities;

namespace Service.WPF.ViewModels
{
    public class NavBarViewModel : Screen
    {
        private readonly IStorage _storage;

        #region Properties

        private ObservableCollection<INavBarItemModel> _navBarItems;

        public ObservableCollection<INavBarItemModel> NavBarItems
        {
            get => _navBarItems;
            set
            {
                _navBarItems = value;
                NotifyOfPropertyChange(() => NavBarItems);
            }
        }

        #endregion

        public NavBarViewModel(IStorage storage)
        {
            _storage = storage;
            _navBarItems = new ObservableCollection<INavBarItemModel>(_storage.NavBarItems);
        }
    }
}