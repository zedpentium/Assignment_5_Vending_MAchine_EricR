using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Vending_Machine_EricR.Model
{
    public class OutputFormatting
    {
        public static void OutputFormat(string message, int money, string messagetwo)
        {
            Console.WriteLine("__________ Welcome to Eric R mixed items Vendormachine __________\nAT broderlands school of science.\n");
            Console.WriteLine($"99 - Input money\n");
            Console.WriteLine($"1 - Input money");
            Console.WriteLine($"Amount of money put in: {money}");
            Console.WriteLine($"Put in money with ");

        }

    }

}
