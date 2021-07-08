using System;
using System.Collections.Generic;
using Assignment_5_Vending_Machine_EricR.Model;
using Assignment_5_Vending_Machine_EricR.Data;

namespace Assignment_5_Vending_Machine_EricR
{
    class Program
    {



        public static void Main(string[] args)
        {


            VendingMachine.AcceptedVendingCurrency(1, "kr");
            VendingMachine.AcceptedVendingCurrency(5, "kr");
            VendingMachine.AcceptedVendingCurrency(10, "kr");
            VendingMachine.AcceptedVendingCurrency(20, "kr");
            VendingMachine.AcceptedVendingCurrency(50, "kr");
            VendingMachine.AcceptedVendingCurrency(100, "kr");
            VendingMachine.AcceptedVendingCurrency(500, "kr");
            VendingMachine.AcceptedVendingCurrency(1000, "kr");

            

            StoreVendorItems();


            // For testing to see that all currency are stored
            foreach (var currency in VendingMachine.StoredCurrencyValue)
            {
                Console.WriteLine(currency);
            }

            foreach (var item in VendingMachine.listOfInventory)
            {
                Console.WriteLine(item.Info());
            }

            Console.ReadKey();



            //Console.WriteLine("\nInfo list");
            //foreach (AbstractVending items in VendingMachine.listOfInventory)
            //{
            //    Console.WriteLine(items.Info());
            //}

            //string display = "";



            //VendingMachine[] foundAllOne = showemAll.ShowAll();

            //foreach (var item in showemAll.ShowAll())
            //{
            //   display += " " + item;
            //}

            //Console.WriteLine(display);
            //string[] display = Array.ConvertAll(showObjects.ShowAll(), o => o.ToString());
            //Console.WriteLine( objectArray.Select(o => o.ToString()).ToArray());
            //string[] display = Array.ConvertAll(showemAll.ShowAll(), o => o.ToString());

            //Console.WriteLine(showObjects.Purchase(21));
            //VendingMachine[] tempArray = new VendingMachine[30];
            //tempArray = showObjects.ShowAll();



            /*foreach (VendingMachine products in showObjects.ShowAll())
            {
              Console.WriteLine(products.ToString());
            }*/

            //Console.WriteLine(VendingMachine.StoredCurrencyValue.Info());


            //Console.WriteLine(string.Join(",", display));


            /*bool VendorMenu = true;
            do
            {
                Console.Write("\r\nSkriv in NR på menyval & tryck enter: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            MAddition();
                            break;
                        case "2":
                            MSubtraktion();
                            break;
                        case "3":
                            MDivision();
                            break;
                        case "4":
                            MMultiplikation();
                            break;
                        case "0":
                            showMenu = false; // stoppa switch-loopen och gå till slut av Main = slut på programmet
                            break;
                        default:
                            Console.WriteLine("Det är inte ett giltigt meny nummer! Tryck enter och försök igen.");
                            Console.ReadKey();
                            break;
                    }



            } while (VendorMenu = true) ;

            //Console.WriteLine("Hello World!");
            */

            //VendingMachine storingItems = new VendingMachine(); // creating this object to be able to down below store items in
            // VendingInventory array




        }  // end main

        
        static void StoreVendorItems()
        {

                    // Catagories
            //string cataA = "Drinkable";
            //string cataB = "Eatable";
            //string cataC = "SchoolSupplies";

            VendingMachine drinksA = new Drinkable(1, "Coca Cola", "33cl Can, Carbonated, Sugar, Dark Liquid", 15);
            Drinkable drinksB = new Drinkable(2, "Orange Juice", "50cl plastic bottle, Sugar, With pulp", 25);
            Drinkable drinksC = new Drinkable(3, "Spring-gu Bottled Water", "50cl plastic bottle", 33);

            Eatable eatA = new Eatable(11, "Cheese Sandwich", "Cheddar, White bread, Plasticwrapped", 35);
            Eatable eatB = new Eatable(12, "Chocolate Ball", "With Cocos, Coffie-taste", 10);
            Eatable eatC = new Eatable(13, "Candy Bar", "2 bits, 100g, Sugar, Chocolate, Nuts", 15);

            SchoolSupplies SchoolsupA = new SchoolSupplies(21, "Pencil", "Pre-sharpened, Wood-body", 3);
            SchoolSupplies SchoolsupB = new SchoolSupplies(22, "Small Notebook", "Lines, Recycled paper", 18);
            SchoolSupplies SchoolsupC = new SchoolSupplies(23, "Eraser", "Rectangular, Rounded edges", 7);

            AbstractVending[] vendarray = new AbstractVending[9]
            { drinksA, drinksB, drinksC, eatA , eatB, eatC, SchoolsupA, SchoolsupB, SchoolsupC};


            //vendarray.CopyTo(VendingMachine.listOfInventory, 0);
            

            //VendingMachine.SaveVendorItems(drinksA);

        }







    } // end program

} // end namespace
