using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5_Vending_Machine_EricR.Model;

namespace Assignment_5_Vending_Machine_EricR.Data
{
    class VendingInventory
    {

        public static int arrayCounter = 0;


        static Dictionary<int, string> StoredCurrencyValue = new Dictionary<int, string>();

        static VendingInventory[] _listOfInventory = new VendingInventory[9];


        public static void StoreVendorItems(int slotNumber, string category, string productName, string productDetails, int price)
        {
            VendingMachine newVendorItem = new AbstractVending(slotNumber, category, productName, productDetails, price);
            _listOfInventory[arrayCounter] = newVendorItem;
            arrayCounter++;

        }


        public static void AcceptedVendingCurrency(int amount, string currency)
        {
            StoredCurrencyValue.Add(amount, currency);
        }
    }
}
