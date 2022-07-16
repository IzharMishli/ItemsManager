using ItemsManager.WPF.Commands;
using ItemsManager.WPF.Helpers;
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
    public class ItemsViewerViewModel : ViewModelBase
    {
        private List<string> itemTypesList;

        public List<string> ItemTypesList
        {
            get { return itemTypesList; }
        }

        private ObservableCollection<ItemsModel> itemsData;

        public ObservableCollection<ItemsModel> ItemsData
        {
            get { return itemsData; }
            set { 
                itemsData = value;
                OnPropertyChanged(nameof(ItemsData));
            }
        }

        

        public ICommand FilterViewCommand { get; }


        public ItemsViewerViewModel(ObservableCollection<ItemsModel> itemsData, 
            FullItemsStore fullItemsStore)
        {
            ItemsData = itemsData;
            itemTypesList = Enum.GetNames(typeof(ItemTypesHelper.ItemTypes)).ToList();
            FilterViewCommand = new FilterItemTypeCommand(ItemsData , fullItemsStore);

            

        }

    }
}
