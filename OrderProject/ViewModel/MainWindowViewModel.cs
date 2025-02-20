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

        private readonly AruViewModel _aruViewModel = new AruViewModel();
        private readonly MegrendelesViewModel _megrendelesViewModel = new MegrendelesViewModel();
        private readonly KezelesViewModel _kezelesViewModel = new KezelesViewModel();
        private readonly ModositasViewModel _modositasViewModel = new ModositasViewModel();

        [ObservableProperty]
        private object _currentView = new object();

        public MainWindowViewModel()
        {
            _currentView = _aruViewModel;
        }

        [RelayCommand]
        private void ShowMegrendelesView()
        {
            CurrentView = _megrendelesViewModel;
        }

        [RelayCommand]
        private void ShowAruView()
        {
            CurrentView = _aruViewModel;
        }

        [RelayCommand]
        private void ShowModositasView()
        {
            CurrentView = _modositasViewModel;
        }

        [RelayCommand]
        private void ShowKezelesView()
        {
            CurrentView = _kezelesViewModel;
        }
    }
}
