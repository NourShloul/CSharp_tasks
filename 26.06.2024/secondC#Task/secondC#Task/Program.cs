using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace secondC_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1.	Write a C# program that accept two integers and display the smaller.
            Console.WriteLine("--------------------------Answer1---------------------------");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Min(num1, num2));



            // 2.	 Write a C# conditional statement to find the sign  of input  number. Display sign. Go
            // •	Sample numbers: -7
            // •	Output: The sign is -
            Console.WriteLine("--------------------------Answer2---------------------------");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int sign = Math.Sign(num3);
            Console.WriteLine(sign > 0 ? "the sign is: +" : sign < 0 ? "the sign is: - ":"the number is 0");



            // 3.	Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            // •	Sample numbers: 0, -1, 4
            // •	Output: 4, 0, -1
            Console.WriteLine("--------------------------Answer3---------------------------");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());
            int[] arr = { num4, num5, num6 };
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine($"Output: {arr[0]}, {arr[1]}, {arr[2]}");




            // 4.	Write a C# conditional statement to find the max of five numbers. Use console to display the result.
            // •	Sample numbers: -5, -2, -6, 0, -1
            // •	Output: 0
            Console.WriteLine("--------------------------Answer4---------------------------");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = Convert.ToInt32(Console.ReadLine());
            int num9 = Convert.ToInt32(Console.ReadLine());
            int num10 = Convert.ToInt32(Console.ReadLine());
            int num11 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = { num7, num8, num9, num10, num11 };
            Array.Sort(arr1);
            int max = arr1.Max();
            Console.WriteLine(max);



            // 5.	 Write a C# program that converts kilometers per hour to miles per hour.
            // Expected Output:
            // •	Input kilometers per hour: 15.
            // •	9.320568 miles per hour
            Console.WriteLine("--------------------------Answer5---------------------------");
            Console.WriteLine("Input ");
            int kilometersPerHour = Convert.ToInt32(Console.ReadLine());
            double milesPerHour = kilometersPerHour * 0.621371;
            Console.WriteLine(milesPerHour + " miles per hour");



            // 6.	Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
            // •	Input hours: 5
            // •	Input minutes: 37
            // •	Total: 337 minutes.
            Console.WriteLine("--------------------------Answer6---------------------------");
            int hour = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());
            int total = (hour * 60) + minute;
            Console.WriteLine(total);




            // 7.	Write a program in C# that takes minutes as input and display the total number of hours and minutes.
            // •	Input minutes: 546
            // •	9 Hours, 6 Minutes
            Console.WriteLine("--------------------------Answer7---------------------------");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int hours = minutes / 60;
            int mins = minutes % 60;
            Console.WriteLine($"{hours} Hours, {mins} Minutes");




            // 8.	Create string of array that contains 5 element of different sentence with different length .
            // Print all elements with fixed length for each sentence.
            Console.WriteLine("--------------------------Answer8---------------------------");
            string[] ar = { "Hello,My Name is Nour", "I am a Computer Engineer", "And a Full-Stack Developer trainee", "at Orange Coding Academy", "I Love Coding" };
            Console.WriteLine($"{ar[0]}, the length for this sentence is: {ar[0].Length}");
            Console.WriteLine($"{ar[1]}, the length for this sentence is: {ar[1].Length}");
            Console.WriteLine($"{ar[2]}, the length for this sentence is: {ar[2].Length}");
            Console.WriteLine($"{ar[3]}, the length for this sentence is: {ar[3].Length}");
            Console.WriteLine($"{ar[4]}, the length for this sentence is: {ar[4].Length}");
        }
    }
}
