using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._07._2024
{
    class Car
    {
        //1.Implement a Car class which has fields to store the car's make, year, Type, Price, model, Pallet No, and color
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string Model { get; set; }
        public int PalletNo { get; set; }
        public string Color { get; set; }
        public void DisplayInfo(string make, int year) 
        {
            Console.WriteLine($"The Car's Make: {make}, and car's year: {year}");
        }
        public void DisplayInfo(string make)
        {
            Console.WriteLine($"The Car's Make: {make}");
        }
        public virtual void Display() 
        {
            Console.WriteLine("Welcome Car");
        }
    }
    class BMW : Car
    {
        public override void Display()
        {
            Console.WriteLine("Welcome BMW");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Before Override-------------");
            BMW bMW = new BMW();
            bMW.Display();


            Console.WriteLine("-------------After Override-------------");
            BMW bMW1 = new BMW();
            bMW1.Display();
            Car bMW2 = new BMW();
            bMW2.Display();


        }
    }
}
