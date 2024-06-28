using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1-	Correct the syntax error:
            Console.WriteLine("------------------------------------Answer1------------------------------------");
            //•	string [ ] ARR= [ 1,7  9  45, ]
            int[] ARR = { 1, 7, 9, 45 };
            Console.WriteLine("the Correct syntax is: int[] ARR = { 1, 7, 9, 45 };");
            //•	int arr2=["Str" "alex","moh"
            string[] arr2 = { "Str", "alex", "moh" };
            Console.WriteLine("the Correct syntax is: string[] arr2 = { \"Str\", \"alex\", \"moh\" };");
            //•	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            Console.WriteLine("the Correct syntax is: string[] arr3 = { \"the\", \"fox\", \"over\", \"lazy\", \"dog\" };");

            /*2-	What the index of "Banana","Tomato"?
            String [ ]  fruits=["Tomato","Banana","Watermelon"]*/
            Console.WriteLine("------------------------------------Answer2------------------------------------");
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            //"Banana" in the index 1
            Console.WriteLine($"the index of Banana is: {Array.IndexOf(fruits, "Banana")}");
            //"Tomato" in the index 0
            Console.WriteLine($"the index of Tomato is: {Array.IndexOf(fruits, "Tomato")}");


            /*3-	Create an multiple arrays that represents your:
            •	Favorite Food (5 item)
            •	Favorite Sport (3 item)
            •	Favorite Movie (4 item)
            Then, print each array using foreach, and Loop Through an Array*/
            Console.WriteLine("------------------------------------Answer3------------------------------------");
            string[] Food = { "Pizza", "Mansaf", "Makmurah", "Pasta", "Maqlubah" };
            string[] Sport = { "Yoga", "Pilats", "Swimming" };
            string[] Movie = { "The Legend", "Django", "Taken", "The Notebook" };
            foreach (string i in Food)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
            foreach (string i in Sport)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
            foreach (string i in Movie)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            /*4-	Write a program in C# to calculate the sum of
             three numbers with getting input in one line separated by a comma
            Expected Output:
            •	Input three numbers separated by comma: 5,10,15
            •	The sum of three numbers: 30.*/
            Console.WriteLine("------------------------------------Answer4------------------------------------");
            Console.Write("Input three numbers separated by commas: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);
            int SUM = num1 + num2 + num3;
            Console.WriteLine("The sum of three numbers: " + SUM);


            /*5-	Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
            •	Test Data
            •	The odd numbers are1 3 5 7 9 11 13 15 17 19……
            •	The Sum of odd Numbers is: …...*/
            Console.WriteLine("------------------------------------Answer5------------------------------------");
            int sum = 0;
            Console.Write($"The odd numbers are: ");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The sum of odd Numbers is: {sum}");

            /*6-	Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
            The pattern like:
            *
            **
            ***
            ****   */
            Console.WriteLine("------------------------------------Answer6------------------------------------");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            /*7- Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
            The pattern like :
            1
            2 3
            4 5 6
            7 8 9 10 */
            Console.WriteLine("------------------------------------Answer7------------------------------------");
            int count = 1;
            for (int i = 1; i < 5; i++) 
            { 
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", count++);
                }
                Console.Write("\n");
            }

        }
    }
}
