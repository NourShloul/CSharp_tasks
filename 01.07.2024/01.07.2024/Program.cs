using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024
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

        //2.Implement a constructor for the car class
        //which takes parameters corresponding to each of the fields above and constructs an object with these values
        public Car(string make, int year, string type,string price,string model,int palletNo,string color) 
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
        }
        //3.Implement a method to start and stop engine.
        public void StartEngine()
        {
            Console.WriteLine("Engine started");   
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
        //4.Try to return a string containing full information about the car
        public string CarDetails()
        {
            return $"Car Details:\n Make: {Make}\n Year: {Year}\n Type: {Type}\n Price: {Price}\n Model: {Model}\n Pallet No: {PalletNo}\n Color: {Color}";
        }
    }
    //5.Apply inheritance for the base class (create class BMW (Derived Class))
    class BMW : Car
    {
        public BMW(int year, string type, string price, string model, int palletNo, string color)
            : base("BMW", year, type, price, model, palletNo, color)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------From Parent Class------------------------");
            Car car = new Car("Tesla",2022, "Electric", "$60,000", "Model 3", 67890, "Red");
            Console.WriteLine(car.CarDetails());

            Console.WriteLine("------------------------From Derived Class-----------------------");
            //6.Apply to access the  Derived Class
            BMW bmw = new BMW(2023, "Sedan", "$70,000", "Series 5", 54321, "Black");
            Console.WriteLine(bmw.CarDetails());
            bmw.StartEngine();
            bmw.StopEngine();

        }
    }
}
