using ItemsManager.WPF.Models;
using ItemsManager.WPF.Stores;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ItemsManager.WPF.Commands
{
    internal class OpenJsonCommand : CommandBase
    {

        private ObservableCollection<ItemsModel> _items;
        private readonly FullItemsStore fullItemsStore;

        public ObservableCollection<ItemsModel> Items
        {
            get { return _items; }
            set { _items = value; 
            }
        }

        public OpenJsonCommand(ObservableCollection<ItemsModel> itemsData, 
            FullItemsStore fullItemsStore)
        {
            _items = itemsData;
            this.fullItemsStore = fullItemsStore;
        }
        public override async void Execute(object? parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            openFileDialog.Title = "Select item";
            openFileDialog.InitialDirectory = @"c:\";
            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;

                
                using (StreamReader file = File.OpenText(path))
                {
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject o2 = (JObject)JToken.ReadFrom(reader);
                        //JArray jarr = (JArray)o2["Catalog"];
                        foreach (var c in o2)
                        {
                            if (c.Key == "Catalog")
                            {
                                foreach (var kv in c.Value)
                                {

                                    _items.Add(new ItemsModel(kv.First.First.ToString()));
                                }
                            }
                        }
                    }
                }
            }
            foreach (var item in _items)
            {
                fullItemsStore.ItemsData.Add(item);
            }

        }
    }

    
}
