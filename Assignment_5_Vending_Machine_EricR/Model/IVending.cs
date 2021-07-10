using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5_Vending_Machine_EricR.Data;

namespace Assignment_5_Vending_Machine_EricR.Model
{

    interface IVending
    {

        public bool Purchase(int inProdSlot, out AbstractVending foundProductResult);

        public static AbstractVending[] ShowAll { get; }

        public bool InsertMoney(int inputMoney, out string returnMessage);

        public Dictionary<int, int> EndTransaction();

    }

}
