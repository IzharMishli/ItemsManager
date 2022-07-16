using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ItemsManager.WPF.ViewModels
{
    public class ItemDetailsFormViewModel
    {
        private string itemID;

        public string ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string price;

        public ItemDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool CanSubmit => !string.IsNullOrEmpty(itemID);

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
    }
}
