using System;
using System.Collections.Generic;
using Assignment_5_Vending_Machine_EricR.Model;
using Assignment_5_Vending_Machine_EricR.Data;
using Xunit;
using Xunit.Abstractions;

namespace Assignment_5_Vending_Machine_EricR.Tests
{
    public class EatableTests
    {

        private readonly ITestOutputHelper output;

        public EatableTests(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public void EatableTesting()

        {
            //Arrange --------------
            VendingMachine testRun = new VendingMachine();


            //Act ---------------------
            VendingMachine.ClearArrayCounter();

            // Add all products
            VendingMachine.StoreVendorItems(new Eatable(11, "Cheese Sandwich", "Cheddar, White bread, Plasticwrapped", 35));
            VendingMachine.StoreVendorItems(new Eatable(12, "Chocolate Ball", "With Cocos, Coffie-taste", 10));
            VendingMachine.StoreVendorItems(new Eatable(13, "Candy Bar", "2 bits, 100g, Sugar, Chocolate, Nuts", 15));


            bool buyProductOne = testRun.Purchase(11, out AbstractVending boughtProductOne);
            bool buyProductTwo = testRun.Purchase(13, out AbstractVending boughtProductTwo);

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
