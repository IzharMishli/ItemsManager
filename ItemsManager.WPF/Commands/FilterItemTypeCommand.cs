using ItemsManager.WPF.Models;
using ItemsManager.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ItemsManager.WPF.Commands
{
    public class FilterItemTypeCommand : CommandBase
    {
        private ObservableCollection<ItemsModel> itemsData;
        private readonly FullItemsStore fullItemsStore;

        public FilterItemTypeCommand(ObservableCollection<ItemsModel> itemsData,
            FullItemsStore fullItemsStore)
        {
            this.itemsData = itemsData;
            this.fullItemsStore = fullItemsStore;
        }

        public override void Execute(object? parameter)
        {


            itemsData.Clear();
            if (parameter.ToString().Equals("All"))
            {
                foreach (var item in fullItemsStore.ItemsData)
                {
                    itemsData.Add(item);
                }
            }
            else
            {
                foreach (var item in fullItemsStore.ItemsData)
                {
                    if (item.Category == parameter.ToString())
                        itemsData.Add(item);
                }
            }
            
            //MessageBox.Show(parameter.ToString());


            //throw new NotImplementedException();
        }
    }
}
