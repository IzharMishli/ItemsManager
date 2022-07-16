using ItemsManager.WPF.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsManager.WPF.Models
{
    public class ItemsModel
    {

        public ItemsModel(string itemID)
        {
            ItemID = itemID;
            if (itemID.Length==7)
            {
                string test = itemID.Substring(4, 2);
                Price = ItemTypesHelper.Prices[Convert.ToInt32(itemID.Substring(4, 1))].ToString();
                Category = ((ItemTypesHelper.ItemTypes)Convert.ToInt32(itemID.Substring(1, 2))).ToString();
                Availability= ((ItemTypesHelper.Availability)Convert.ToInt32(itemID.Substring(3, 1))).ToString();
                Quality = ((ItemTypesHelper.Quality)Convert.ToInt32(itemID.Substring(4, 1))).ToString();
                
                ImageSource = "../Resources/" + ItemID + ".png";

            }
            
            
        }
        public string ImageSource { get; set; }
        public string ItemID { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Availability { get; set; }
        public string Quality { get; set; }


    }
}
