using ItemsManager.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsManager.WPF.Stores
{
    public class FullItemsStore
    {
        private ObservableCollection<ItemsModel> itemsData;

        public FullItemsStore()
        {
            ItemsData = new ObservableCollection<ItemsModel>();
        }

        public ObservableCollection<ItemsModel> ItemsData
        {
            get { return itemsData; }
            set
            {
                itemsData = value;
            }
        }
    }
}
