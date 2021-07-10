using System;
using System.Collections.Generic;
using System.Text;
using Assignment_5_Vending_Machine_EricR.Model;
using Assignment_5_Vending_Machine_EricR.Data;
using Xunit;
using Xunit.Abstractions;

namespace Assignment_5_Vending_Machine_EricR.Tests
{
    public class AbstractVendingTests
    {

        private readonly ITestOutputHelper output;

        public AbstractVendingTests(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public void AbstractVeningtesting() // Test of the abstract "product" class

        {
            //Arrange ---------------------------
            VendingMachine testRun = new VendingMachine();


            //Act -------------------------------
            VendingMachine.ClearArrayCounter();

            // Add all products
            VendingMachine.StoreVendorItems(new Drinkable(1, "Coca Cola", "33cl Can, Carbonated, Sugar, Dark Liquid", 15));
            VendingMachine.StoreVendorItems(new Drinkable(2, "Orange Juice", "50cl plastic bottle, Sugar, With pulp", 25));
            VendingMachine.StoreVendorItems(new Drinkable(3, "Spring-gu Bottled Water", "50cl plastic bottle", 33));
            VendingMachine.StoreVendorItems(new Eatable(11, "Cheese Sandwich", "Cheddar, White bread, Plasticwrapped", 35));
            VendingMachine.StoreVendorItems(new Eatable(12, "Chocolate Ball", "With Cocos, Coffie-taste", 10));
            VendingMachine.StoreVendorItems(new Eatable(13, "Candy Bar", "2 bits, 100g, Sugar, Chocolate, Nuts", 15));
            VendingMachine.StoreVendorItems(new SchoolSupplies(21, "Pencil", "Pre-sharpened, Wood-body", 3));
            VendingMachine.StoreVendorItems(new SchoolSupplies(22, "Small Notebook", "Lines, Recycled paper", 18));
            VendingMachine.StoreVendorItems(new SchoolSupplies(23, "Eraser", "Rectangular, Rounded edges", 7));


            bool buyProductOne = testRun.Purchase(2, out AbstractVending boughtProductOne);
            bool buyProductTwo = testRun.Purchase(13, out AbstractVending boughtProductTwo);
            bool buyProductThree = testRun.Purchase(22, out AbstractVending boughtProductThree);

            string detailsA = boughtProductTwo.Examine(boughtProductTwo);
            string detailsB = boughtProductOne.Examine(boughtProductOne);

            string usageusingItA = boughtProductOne.Use(boughtProductOne);
            string usageusingItB = boughtProductTwo.Use(boughtProductTwo);
            string usageusingItC = boughtProductThree.Use(boughtProductThree);

            //Assert -----------------------------

            output.WriteLine($"Details of {boughtProductOne} {detailsA}"); // testing the Examine()
            output.WriteLine($"Details of {boughtProductTwo} {detailsB}");

            output.WriteLine($"{usageusingItA}"); // testing the Use()
            output.WriteLine($"{usageusingItB}");
            output.WriteLine($"{usageusingItC}");

            output.WriteLine($"{boughtProductThree.ToString()}"); // testing the ToString & the constructor and props(reading object info via them)

        }

    }






}



