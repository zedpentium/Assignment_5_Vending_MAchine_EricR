using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5_Vending_Machine_EricR.Data;

namespace Assignment_5_Vending_Machine_EricR.Model
{

    interface IVending
    {

        VendingMachine Purchase(int inProdSlot);

        VendingMachine[] ShowAll();

        int InsertMoney();

        Dictionary<int, string> EndTransaction();

    }

}
