using System;
using System.Runtime.CompilerServices;

namespace MyNamespace
{
        public delegate void showInfo();
        public delegate void changeDelegate(string message);
    class Program
    {
        public static void Main(string[] args)
        {
            changeDelegate displayMessage = (string message) => // lambda expression for a delegate
            {
                Console.WriteLine(message);
            };

            string executeMessage = "\t\t\tTHE PROGRAM HAS SUCCESSFULLY EXECUTED";
            string terminateMessage = "\t\t\tTHE PROGRAM HAS SUCCESSFULLY TERMINATED !";

            displayMessage(executeMessage);


            IVehicle vehicle = null;

            Console.WriteLine("Enter Name for car: ");
            string Name= Console.ReadLine();

            Console.WriteLine("Entrer Chassis for car: ");
            double chassis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Horse Power for car: ");
            double horsePower = Convert.ToInt32(Console.ReadLine());

            vehicle = new Car(Name, horsePower,chassis, -10);

            vehicle.Display();      // achieving polymorphic behavior using an interface;


             

            Console.WriteLine("Enter Name for bike: ");
             Name = Console.ReadLine();

            Console.WriteLine("Entrer Chassis for bike: ");
             chassis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Horse Power for bike: ");
             horsePower = Convert.ToInt32(Console.ReadLine());

            vehicle = new Bike(Name,horsePower,chassis, 220);
            vehicle.Display();


            Console.WriteLine("\n\nUsing Delegate to transfer instance method of Car to Bike");

            //vehicle.Both(carInfo);            // is an error because when we use interface only methods in that interface are usable like (vehicle = new Bike(Console.ReadLine(),horsePower,chassis, 220); is not usable)

            Car test_car = new Car("test car",99,9999,90);
            showInfo carInfo = test_car.Display;


            Bike test_bike = new Bike("test bike", 88, 8888, 80);
            carInfo += test_bike.Display;

            test_bike.Both(carInfo);            // passing an argument of test_car object instance method to bike.

            displayMessage(terminateMessage);

            carInfo?.Invoke();
            
        }
    }

}