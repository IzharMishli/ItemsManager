using ItemsManager.WPF.Commands;
using ItemsManager.WPF.Models;
using ItemsManager.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ItemsManager.WPF.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel MainInstance { get; }
        public ItemsViewerViewModel itemsViewerViewModel { get; }
        public FullItemsStore fullItemsStore { get; }
        private readonly ModalNavigationStore _modalNavigationStore;

        public ICommand OpenAddItemCommand { get; }
        public ICommand ExportToJsonCommand { get; }
        public ICommand OpenJsonCommand { get; }
        

        private ObservableCollection<ItemsModel> itemsData;

        public ObservableCollection<ItemsModel> ItemsData
        {
            get { return itemsData; }
            set { itemsData = value;
            }
        }



        public MainWindowViewModel()
        {
            MainInstance = this;
            
            _modalNavigationStore = new ModalNavigationStore();
            itemsData = new ObservableCollection<ItemsModel>();
            fullItemsStore = new FullItemsStore();
            itemsViewerViewModel = new ItemsViewerViewModel(ItemsData, fullItemsStore);
            
            //Commands:
            OpenAddItemCommand = new AddItemCommand();
            ExportToJsonCommand = new ExportToJsonCommand();
            OpenJsonCommand = new OpenJsonCommand(ItemsData, fullItemsStore);
            
        }

    }
}
