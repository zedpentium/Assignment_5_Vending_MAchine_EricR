using System;
using System.Collections.Generic;
using Assignment_5_Vending_Machine_EricR.Model;
using Assignment_5_Vending_Machine_EricR.Data;
using Xunit;
using Xunit.Abstractions;

namespace Assignment_5_Vending_Machine_EricR.Tests
{
    public class SchoolSuppliesTests
    {

        private readonly ITestOutputHelper output;

        public SchoolSuppliesTests(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public void SchoolSuppliesTestsTesting()

        {
            //Arrange --------------
            VendingMachine testRun = new VendingMachine();


            //Act ---------------------
            VendingMachine.ClearArrayCounter();

            // Add all products
            VendingMachine.StoreVendorItems(new SchoolSupplies(21, "Pencil", "Pre-sharpened, Wood-body", 3));
            VendingMachine.StoreVendorItems(new SchoolSupplies(22, "Small Notebook", "Lines, Recycled paper", 18));
            VendingMachine.StoreVendorItems(new SchoolSupplies(23, "Eraser", "Rectangular, Rounded edges", 7));


            bool buyProductOne = testRun.Purchase(22, out AbstractVending boughtProductOne);
            bool buyProductTwo = testRun.Purchase(23, out AbstractVending boughtProductTwo);

            string detailsA = boughtProductTwo.Examine(boughtProductTwo);
            string detailsB = boughtProductOne.Examine(boughtProductOne);

            string usageusingItA = boughtProductOne.Usage();
            string usageusingItB = boughtProductTwo.Usage();


            //Assert -----------------------

            output.WriteLine($"{usageusingItA}"); // testing the Useage()
            output.WriteLine($"{usageusingItB}");

            output.WriteLine($"{boughtProductTwo.Info()}"); // testing the Info & the constructor and props(reading object info via them)



        }


    }
}
