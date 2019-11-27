using System;
using Caliburn.Micro;

namespace Service.WPF.ViewModels
{
    public class ShellViewModel : Conductor<Screen>
    {
        private readonly NavBarViewModel _navBarViewModel;

        public ShellViewModel(NavBarViewModel navBarViewModel)
        {
            _navBarViewModel = navBarViewModel;
            ActivateItem(_navBarViewModel);
        }

        public void TestButton()
        {
            
        }
    }
}
