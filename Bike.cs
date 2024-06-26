using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    public class Bike:IVehicle {
        public Bike()
        {

        }
        public Bike(string name, double hp, double chassis, double speed)
        {
            this.Name = name; ;
            this.Chassis = chassis;
            this.HorsePower = hp;
            this.topSpeed = speed;
        }
        public string Name { get; set; }
        public double HorsePower { get; set; }
        public double Chassis { get; set; }

        private double topSpeed;
        public double TopSpeed {
            get { return topSpeed; }
            set
            {
                if (value >= 0)
                {
                    topSpeed = value;
                }
                else 
                {
                    topSpeed=0;
                }
            }

        }


        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    \t\t Displaying information of Bike");
            Console.WriteLine($"     NAME: {Name} ");
            Console.WriteLine($"     HorsePower: {HorsePower} ");
            Console.WriteLine($"     Chassis Number: {Chassis}");
            Console.WriteLine($"     Top Speed: {TopSpeed}");
            Console.ResetColor();
        }

        public void Both(showInfo info)
        {
            Console.WriteLine("\n---------------------------------");
            info();                                                     //receiving an instance of a function here
            Console.WriteLine("\n---------------------------------");
            this.Display();
        }
    }

}
