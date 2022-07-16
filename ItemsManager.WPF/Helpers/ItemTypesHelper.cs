using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsManager.WPF.Helpers
{
    static public class ItemTypesHelper
    {
        public enum ItemTypes
        {
            Hat,
            TopWear,
            BottomWear,
            Shoes,
            Face,
            Skin,
            Hair,
            HairHatMode,
            CurrencyGold,
            CurrencyDiamond,
            NameTag,
            Copuns,
            GiftsPackage,
            Dances
        }

        public enum itemGender
        {
            Male,
            Female,
            Unisex,
            NonGender,
            Bundle
        }

        public enum Availability
        {
            InStore,
            NonStore

        }

        static public List<string> Prices = new List<string>() { "2500", "12500", "37500", "75000"};

        public enum Quality
        {
            Common,
            Rare,
            Epic,
            Legendary
        }

        


    }
}
