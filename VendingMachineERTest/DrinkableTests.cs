using System;
using System.Collections.Generic;
using Assignment_5_Vending_Machine_EricR.Model;
using Assignment_5_Vending_Machine_EricR.Data;
using Xunit;
using Xunit.Abstractions;

namespace Assignment_5_Vending_Machine_EricR.Tests
{
    public class DrinkableTests
    {

        private readonly ITestOutputHelper output;

        public DrinkableTests(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public void DrinkableeTesting()

        {
            //Arrange --------------
            VendingMachine testRun = new VendingMachine();


            //Act ---------------------
            VendingMachine.ClearArrayCounter();

            // Add all products
            VendingMachine.StoreVendorItems(new Drinkable(1, "Coca Cola", "33cl Can, Carbonated, Sugar, Dark Liquid", 15));
            VendingMachine.StoreVendorItems(new Drinkable(2, "Orange Juice", "50cl plastic bottle, Sugar, With pulp", 25));
            VendingMachine.StoreVendorItems(new Drinkable(3, "Spring-gu Bottled Water", "50cl plastic bottle", 33));


            bool buyProductOne = testRun.Purchase(2, out AbstractVending boughtProductOne);
            bool buyProductTwo = testRun.Purchase(3, out AbstractVending boughtProductTwo);

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
