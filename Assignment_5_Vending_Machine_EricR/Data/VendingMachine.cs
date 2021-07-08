using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5_Vending_Machine_EricR.Model;

namespace Assignment_5_Vending_Machine_EricR.Data
{
    class VendingMachine : AbstractVending
    {


        public string ProductDetails { get; set; }
        public int Price { get; set; }

        public VendingMachine(int slotNumber, string productDetails, int price) : base(SlotNumber, ProductName)
        {
            //Category = category;
            ProductDetails = productDetails;
            Price = price;
        }


        public static int arrayCounter = 0;


        public static Dictionary<int, string> StoredCurrencyValue = new Dictionary<int, string>();

        public static VendingMachine[] listOfInventory = new VendingMachine[9];



        public static void AcceptedVendingCurrency(int amount, string currency)
        {
            StoredCurrencyValue.Add(amount, currency);
        }



        public VendingMachine Purchase(int inProdSlot)
        {
            VendingMachine foundProduct = Array.Find(listOfInventory, idNr => idNr.SlotNumber == inProdSlot);

            return foundProduct;
            //throw new NotImplementedException();
        }

        public static VendingMachine[] ShowAll()
        {
            return listOfInventory;
        }

        public static int InsertMoney()
        {
            throw new NotImplementedException();
        }

        public static Dictionary<int, string> EndTransaction()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ToString Override
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            return $"------- VendorMachine Inventory\nSlot\tCategory\tProduct\tDetails\tPrice\n{SlotNumber}\t{ProductName}\t{ProductDetails}\t{Price}";

        }





        //public static void StoreVendorItems(int slotNumber, string category, string productName, string productDetails, int price)
        //{
        //    VendingMachine newVendorItem = new VendingMachine(slotNumber, category, productName, productDetails, price);
        //    _listOfInventory[arrayCounter] = newVendorItem;
        //    arrayCounter++;

        //}

        public static void SaveVendorItems(VendingMachine storeThisVendorItem)
        {
            listOfInventory[arrayCounter] = storeThisVendorItem;
            arrayCounter++;
        }
    }
}
