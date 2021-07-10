using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Vending_Machine_EricR.Model
{
    public abstract class AbstractVending
        {


        public int SlotNumber { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public abstract string Info();
        public abstract string Usage();

        public AbstractVending(int slotNumber, string productName, int price)
        {
            SlotNumber = slotNumber;
            ProductName = productName;
            Price = price;
        }


        public string Examine(AbstractVending produktInfo)
        {
            return $"\n{produktInfo.Info()}\n";
        }


        public string Use(AbstractVending produktInfo)
        {
            return $"\n{produktInfo.Usage()}\n";
        }


        public override string ToString()
        {
            return $"\nSlotNumber: {SlotNumber}\tName: {ProductName}\n";
        }
    }






}



