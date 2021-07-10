using System;
using System.Collections.Generic;
using Assignment_5_Vending_Machine_EricR.Model;
using Assignment_5_Vending_Machine_EricR.Data;
using Xunit;
using Xunit.Abstractions;

namespace Assignment_5_Vending_Machine_EricR.Tests
{
    public class VendingMachineTests
    {

        private readonly ITestOutputHelper output;

        public VendingMachineTests(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public void InsertMoneyBuyTwoItemsEndBuyExamineAndUseTest()

        {
            //Arrange --------------

            string displayChange = "";
            VendingMachine testRun = new VendingMachine();


            //Act ---------------------
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


            // Output all products to string, to use Contains to check if they are stored.
            string productShow = "";
            foreach (AbstractVending item in VendingMachine.ShowAll())
            {
                if (item == null) { break; }
                productShow += item.ToString();
            }

            bool moneyAccepted = testRun.InsertMoney(500, out string messageYes);
            bool moneyNotAccepted = testRun.InsertMoney(49, out string messageNot);

            bool buyProductOne = testRun.Purchase(2, out AbstractVending boughtProductOne);
            bool buyProductTwo = testRun.Purchase(13, out AbstractVending boughtProductTwo);
            bool buyProductThree = testRun.Purchase(22, out AbstractVending boughtProductThree);



            string details = boughtProductTwo.Examine(boughtProductTwo);

            string usageusingItA = boughtProductTwo.Use(boughtProductTwo);
            string usageusingItB = boughtProductThree.Use(boughtProductThree);


            //Assert -----------------------

            Assert.True(moneyAccepted);
            Assert.False(moneyNotAccepted);

            Assert.Contains("Money input accepted and added", messageYes);
            Assert.Contains("Money input is NOT equal to any of theese denomination", messageNot);

            Assert.Contains("Cheese Sandwich", productShow); // loose string check, if theese 3 are stored
            Assert.Contains("Pencil", productShow);
            Assert.Contains("21", productShow);

            if (buyProductOne)
            {
                Assert.Contains(boughtProductOne, VendingMachine.boughtItems);
            }
            if (buyProductTwo)
            {
                Assert.Contains(boughtProductTwo, VendingMachine.boughtItems);
            }
            if (buyProductThree)
            {
                Assert.Contains(boughtProductThree, VendingMachine.boughtItems);
            }


            Assert.Contains("2 bits, 100g, Sugar, Chocolate,", details);

            Assert.Contains("You are eating the" , usageusingItA);

            output.WriteLine($"Details of {boughtProductTwo} {details}");
            output.WriteLine($"{usageusingItA}");
            output.WriteLine($"{usageusingItB}");


            foreach (KeyValuePair<int, int> item in testRun.EndTransaction())
            {
                displayChange += $"{item.Value} of {item.Key}\n"; 
                
            }

            output.WriteLine($"Change back: {testRun.MoneyPool}\n");

            output.WriteLine($"Change back in bills & coins:\n{displayChange}");


        }


    }
}
