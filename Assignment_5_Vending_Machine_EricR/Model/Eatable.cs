using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment_5_Vending_Machine_EricR.Model
{
    public class Eatable : AbstractVending
    {
        public string ProductDetails { get; set; }
        public int Price { get; set; }

        public Eatable(int slotNumber, string productName, string productDetails, int price) : base(slotNumber, productName, price)
        {
            ProductDetails = productDetails;
            //Price = price;
        }

        //public Dictionary<int, string> EndTransaction()
        //{
        //    throw new NotImplementedException();
        //}

        //public int InsertMoney()
        //{
        //    throw new NotImplementedException();
        //}

        //public VendingMachine Purchase(int inProdSlot)
        //{
        //    throw new NotImplementedException();
        //}

        //public VendingMachine[] ShowAll()
        //{
        //    throw new NotImplementedException();
        //}

        public override string Info()
        {
            //    return $"_ Drinkable Detailt _\nId: {SlotNumber}\nName: {ProductName}\nPelt: {Pelt}\nTail: {Tail}\n";
            return $"Slot\tCategory\tProduct\tDetails\tPrice\n{SlotNumber}\t{ProductName}\t{ProductDetails}\t{Price}";

        }

        public override string Usage()
        {
            return $"You are eating the {ProductName}, mm not bad.";
        }
    }
}
