using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02._07._2024_2
{
    interface ISound 
    {
        void MakeSound();
    }
    abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            this.Name = name;
        }
        public abstract void Eat();
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }
    }
    class Cat:Animal,ISound
    {
        public Cat(string name):base(name)
        {
        }
        public override void Eat()
        {
            Console.WriteLine($"The {Name} is eating fish");
        }
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
    class Dog:Animal,ISound
    {
        public Dog(string name) : base(name)
        {
        }
        public override void Eat() 
        {
            Console.WriteLine($"The {Name} is eating chicken");
        }
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------CAT------------");
            Cat cat = new Cat("Kitty");
            cat.Eat();
            cat.Sleep();
            cat.MakeSound();

            Console.WriteLine("------------DOG------------");
            Dog dog = new Dog("Doggy");
            dog.Eat();
            dog.Sleep();
            dog.MakeSound();

        }
    }
}
