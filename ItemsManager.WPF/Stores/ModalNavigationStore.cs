using ItemsManager.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsManager.WPF.Stores
{
    public class ModalNavigationStore
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel { 
            get => _currentViewModel; 
            set => _currentViewModel = value; }

        public bool IsOpen => CurrentViewModel != null;

        internal void Close()
        {
            CurrentViewModel = null;
        }

        public event Action CurrentViewModelChanged;


    }

    
}
