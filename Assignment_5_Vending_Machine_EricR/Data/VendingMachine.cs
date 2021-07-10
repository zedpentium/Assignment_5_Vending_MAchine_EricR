using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5_Vending_Machine_EricR.Model;

namespace Assignment_5_Vending_Machine_EricR.Data
{
    public class VendingMachine : IVending
    {

        //private static int _arrayStoreCounter = 0;
        private static int _moneyPool = 0;
        private static int[] StoredCurrencyValue = new int[] {1000, 500, 100, 50, 20, 10, 5, 1 };
        private static AbstractVending[] listOfInventory = new AbstractVending[0];
        public static AbstractVending[] boughtItems = new AbstractVending[0];

        public int MoneyPool
        {
            get { return _moneyPool; }
            set { _moneyPool = value; }
        }

        public VendingMachine()
        {
        }


       

        public bool CanYouAffordThis(int price)
        {
            if (price <= MoneyPool)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Purchase(int inProdSlot, out AbstractVending foundProductResult)
        {
            AbstractVending foundProduct = Array.Find(listOfInventory, idNr => idNr.SlotNumber == inProdSlot);
            foundProductResult = foundProduct;

            bool didYouAfford = CanYouAffordThis(foundProduct.Price);

            if (didYouAfford)
            {
                Array.Resize(ref boughtItems, boughtItems.Length + 1);
                boughtItems[boughtItems.Length - 1] = foundProduct;
                MoneyPool += - foundProduct.Price;
            }
            return didYouAfford;
        }


        public static AbstractVending[] ShowAll()
        { 
            return listOfInventory;
        }


        public bool InsertMoney(int inputMoney, out string returnMessage)
        {
            bool okOrNo = false;
            string retMessage = "";

            foreach (int denomination in StoredCurrencyValue)
            {
                if (inputMoney == denomination)
                {
                    MoneyPool += inputMoney;
                    retMessage = "-- Money input accepted and added --";
                    okOrNo = true;
                    break;
                }

                else
                {
                    retMessage = "Money input is NOT equal to any of theese denomination\n-- 1, 5, 10, 20, 50, 100, 500, 1000 --\nPlease input correct ammount:";
                    okOrNo = false; 
                }
            }

            returnMessage = retMessage;
            return okOrNo;
        }

        public Dictionary<int, int> EndTransaction()
        {
            int[] intAmount = new int[StoredCurrencyValue.Length];
            int iChange = MoneyPool;
            int currencyValue;
            Dictionary<int, int> changeMoney = new Dictionary<int, int>();

            try
            {
                for (int i = 0; i < StoredCurrencyValue.Length; i++)
                {
                    if (iChange >= StoredCurrencyValue[i])
                    {
                        currencyValue = iChange / StoredCurrencyValue[i];
                        iChange = iChange - (currencyValue * StoredCurrencyValue[i]);
                        intAmount[i] = currencyValue;
                    }
                    else
                    {
                        intAmount[i] = 0;
                    }
                    changeMoney.Add(StoredCurrencyValue[i], intAmount[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            return changeMoney;
        }



        public static void StoreVendorItems(AbstractVending storeThisVendorItem)
        {
            Array.Resize(ref listOfInventory, listOfInventory.Length + 1);
            listOfInventory[listOfInventory.Length - 1] = storeThisVendorItem;
        }

        //public void StoreObjectInArray(AbstractVending[] theArrayToStoreIn, AbstractVending theObject)
        //{
        //    Array.Resize(ref theArrayToStoreIn, theArrayToStoreIn.Length + 1);
        //    theArrayToStoreIn[theArrayToStoreIn.Length - 1] = theObject;
        //}


        public static void ClearArrayCounter()
        {
            //VendingMachine._arrayStoreCounter = 0;
            Array.Resize(ref listOfInventory, 0);
            Array.Resize(ref boughtItems, 0);
            _moneyPool = 0;

        }

    }
}
