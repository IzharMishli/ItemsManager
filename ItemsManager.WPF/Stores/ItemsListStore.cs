using ItemsManager.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsManager.WPF.Stores
{
    public class ItemsListStore
    {
        public event Action<ItemsModel> ItemAdded;
        public event Action<ObservableCollection<ItemsModel>> ListAdded;

        public async Task Add(ItemsModel item)
        {
            ItemAdded?.Invoke(item);
        }
        public async Task AddList(ObservableCollection<ItemsModel> item)
        {
            ListAdded?.Invoke(item);
        }
    }
}
