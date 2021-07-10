using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment_5_Vending_Machine_EricR.Model
{
    public class SchoolSupplies : AbstractVending
    {
        public string ProductDetails { get; set; }
        public int Price { get; set; }

        public SchoolSupplies(int slotNumber, string productName, string productDetails, int price) : base(slotNumber, productName, price)
        {
            ProductDetails = productDetails;
            //Price = price;
        }


        public override string Info()
        {
            //    return $"_ Drinkable Detailt _\nId: {SlotNumber}\nName: {ProductName}\nPelt: {Pelt}\nTail: {Tail}\n";
            return $"Slot\tCategory\tProduct\tDetails\tPrice\n{SlotNumber}\t{ProductName}\t{ProductDetails}\t{Price}";

        }

        public override string Usage()
        {
            return $"You are using the {ProductName}.";
        }
    }
}
