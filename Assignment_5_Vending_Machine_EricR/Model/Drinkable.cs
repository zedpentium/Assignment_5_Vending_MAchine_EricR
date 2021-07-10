using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5_Vending_Machine_EricR.Data;

namespace Assignment_5_Vending_Machine_EricR.Model
{
    public class Drinkable : AbstractVending
    {
        //public string Category { get; set; }
        public string ProductDetails { get; set; }
        public int Price { get; set; }

        public Drinkable(int slotNumber, string productName, string productDetails, int price ) : base(slotNumber, productName, price)
            {
            ProductDetails = productDetails;
            //Price = price;
            }



        public override string Info()
        {
            //return $"Slot\tCategory\tProduct\tDetails\tPrice\n{SlotNumber}\t{ProductName}\t{ProductDetails}\t{Price}";
            return $"{SlotNumber}\t{ProductName}\t{ProductDetails}\t{Price}";

        }
        
        public override string Usage()
        {
            return $"You are drinking the {ProductName}, ahhh, refreshing.";

        }


        }
}
