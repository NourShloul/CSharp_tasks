using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _30._06._2024
{
    class Person
    {
        public int Age;
        public string Gender;
        public string Name;
        public string Email;
        public string ID;
        public string Phone;

        // Default constructor with default values
        public Person()
        {
            Age = 25;
            Gender = "Female";
            Name = "Nour";
            Email = "example@example.com";
            ID = "1234567891";
            Phone = "0770000833";
        }
        public void SetAge(int age)
        {
            if (age >= 18 && age <= 60)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Age must be between 18 and 60");
            }
        }
        public void SetPhone(string phone)
        {
            if (phone[0] == 0 && phone[1] == 7 && (phone[2] == 7 || phone[2] == 8 || phone[2] == 9))
            {
                Phone = phone;
            }
            else
            {
                Console.WriteLine("Phone number must start with 077, 078, or 079 and be 10 digits long.");
            }
        }
    }
    internal class Program
        {
            static string SumAndAvg()
            {
                int n;
                double sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    n = int.Parse(Console.ReadLine());
                    sum += n;
                }
                return $"The Sum of 10 Numbers is: {sum} and the Average is: {sum / 10}";

            }
            static int getyears(int[] years)
            {
                for (int i = 0; i < years.Length; i++)
                {
                    if (years[i] > 1950)
                    {
                        return years[i];
                    }
                }
                return 0;

            }
            static int AgeInDays(int ageInYears)
            {
                return ageInYears * 365;
            }
            static void Main(string[] args)
            {
                //1-	 Write a function in C# that accept 10 numbers and return sum and average.
                Console.WriteLine("Insert 10 numbers:");
                Console.WriteLine(SumAndAvg());
                //2-	Write a program in C to display the cube of the number up to given an integer.
                Console.Write("Input number of terms : ");
                int n = int.Parse(Console.ReadLine());
                double cube = Math.Pow(n, 3);
                Console.WriteLine($"the cube of {n} is : {cube}");
                //3- Write a program in C# return only numbers in the years array greater than 1950.
                Console.WriteLine(getyears(new[] { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 }));
                //4- Create a function that takes the age in years and returns the age in days.
                Console.WriteLine("Enter age in years:");
                int ageInYears = int.Parse(Console.ReadLine());
                int ageInDays = AgeInDays(ageInYears);
                Console.WriteLine("Age in days: " + ageInDays);

                //5-	Create class that contain the following field:
                //a.Age  between 18 - 60
                //b.Gender
                //c.Name
                //d.E - Mail
                //e.ID
                //f.Phoneshould be started in 077 or 078 or 079
                //Don’t forget the default value.
                Person person = new Person();
                person.SetAge(28);
                person.Gender = "Male";
                person.Name = "Amnah";
                person.Email = "amnah@example.com";
                person.ID = "1234567890";
                person.SetPhone("0771234567");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Gender: {person.Gender}");
                Console.WriteLine($"Name: {person.Name}");
                Console.WriteLine($"Email: {person.Email}");
                Console.WriteLine($"ID: {person.ID}");
                Console.WriteLine($"Phone: {person.Phone}");



            }
        }
    }
