using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.ViewModel
{
    public partial class MegrendelesViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentView = new object();


    }
}
