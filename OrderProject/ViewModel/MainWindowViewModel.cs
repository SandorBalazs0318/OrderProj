using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {

        private readonly FelhasznalokViewModel _felhasznalokViewModel = new FelhasznalokViewModel();
        private readonly AruViewModel _aruViewModel = new AruViewModel();
        private readonly MegrendelesViewModel _megrendelesViewModel = new MegrendelesViewModel();

        public MainWindowViewModel()
        {
            _currentView = _aruViewModel;
        }

        [ObservableProperty]
        private object _currentView = new object();

        [RelayCommand]
        private void ShowMegrendelesView()
        {
            _currentView = _megrendelesViewModel;
        }

        [RelayCommand]
        private void ShowAruView()
        {
            _currentView = _aruViewModel;
        }

        [RelayCommand]

    }
}
