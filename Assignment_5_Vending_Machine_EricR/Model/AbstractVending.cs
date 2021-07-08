using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Vending_Machine_EricR.Model
{
    public abstract class AbstractVending
        {


        public int SlotNumber { get; set; }
        public string ProductName { get; set; }

        public abstract string Info();

        //int _slotNumber { get; set; }
        //string _productName { get; set; }

        //public int SlotNumber
        //{
        //    get { return _slotNumber; }
        //    set { _slotNumber = value; }
        //}

        //public string ProductName
        //{
        //    get { return _productName; }
        //    set { _productName = value; }
        //}


        public AbstractVending(int slotNumber, string productName)
        {
            SlotNumber = slotNumber;
            ProductName = productName;
            //this._slotNumber = slotNumber;
            //this._productName = productName;
        }


        static void Examine()
        {

        }




        static void Use()
        {

        }


        public override string ToString()
        {
            return $"------- VendorMachine Inventory\nSlotNumber: {SlotNumber}\tName: {ProductName}";
        }
    }






}



