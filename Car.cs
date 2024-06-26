using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    public class Car:IVehicle {
        public Car() { 
        }
        public Car(string name, double hp, double chassis, double dryweight) 
        {
            this.Name = name; ;
            this.Chassis = chassis;
            this.HorsePower = hp;    
            this.DryWeight = dryweight;
        }
       public string Name { get; set; }
       public double HorsePower { get; set; }
       public double Chassis { get; set; }

       private double dryWeight;
       public double DryWeight
        {
            get { return dryWeight; }
            set
            {
                if (value >= 0) { dryWeight = value; }
                else { dryWeight = 0; }
            }

        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("     Displaying information of Car");
            Console.WriteLine($"     NAME: {Name} ");
            Console.WriteLine($"     HorsePower: {HorsePower} ");
            Console.WriteLine($"     Chassis Number: {Chassis}");
            Console.WriteLine($"     Dry Weight: {DryWeight}");
            Console.ResetColor();
            

        }

    }

}
