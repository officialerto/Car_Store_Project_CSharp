using Car_Class_Library;
using System;

namespace Car_Shop_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Console.WriteLine("Welcome to the Car Store!");

            int action = chooseAction();

            while (action!=0)
            {
                Console.WriteLine("You chose " + action);
                action = chooseAction();

                switch (action)
                {
                    case 1:
                        Console.WriteLine("You chose to add a new car to the inventory");
                        String carMake = "";
                        String carModel = "";
                        decimal carPrice = 0;

                        Console.WriteLine("What is the car make? ford, gm, nissan etc.");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? corvette, focus, ranger etc.");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);
                        break;
                        

                    default:
                        break;
                }

                //Car c = new Car("Nissan", "Sentra", 7322);
                //Car d = new Car("Ford", "Mustang", 9200);

                //Console.WriteLine("Car c is as follows " + c.Make + " " + c.Model + " " + c.Price);
                //Console.WriteLine("Car d is as follows " + d.Make + " " + d.Model + " " + d.Price);

                //Store s = new Store();

                //s.ShoppingList.Add(c);
                //s.ShoppingList.Add(d);

                //decimal total = s.CheckOut();

                //Console.WriteLine("Store Value is " + total);

                //Console.ReadLine();
            }

        }

        private static void printInventory(Store s)
        {
            foreach (Car c in s.CarList)
            {
                Console.WriteLine("Car: " + c);
            }
        }

        static public int chooseAction()
        {
            int choice;

            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add car to cart (3) checkout");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
