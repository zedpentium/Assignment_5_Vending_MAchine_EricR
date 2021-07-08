using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5_Vending_Machine_EricR.Data;

namespace Assignment_5_Vending_Machine_EricR.Model
{
    class Drinkable : AbstractVending
    {
        //public string Category { get; set; }
        public string ProductDetails { get; set; }
        public int Price { get; set; }

        public Drinkable(int slotNumber, /*string category,*/ string productName, string productDetails, int price ) : base(slotNumber, productName)
            {
            //Category = category;
            ProductDetails = productDetails;
            Price = price;
            }

  

            public override string Info()
            {
            //    return $"_ Drinkable Detailt _\nId: {SlotNumber}\nName: {ProductName}\nPelt: {Pelt}\nTail: {Tail}\n";
            return $"------- VendorMachine Inventory\nSlot\tCategory\tProduct\tDetails\tPrice\n{SlotNumber}\t{ProductName}\t{ProductDetails}\t{Price}";

        }

        }
}
