using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*******************answer1***********************");
            //1-	Create console application that read string from user and print the same string
            Console.Write("Insert your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);


            Console.WriteLine();
            Console.WriteLine("*******************answer2***********************");
            /*   2-	Define variables with kind of
            a.	 Double
            b.	String 
            c.	Char
            d.	Bool
            e.	Int
            f.	Const
            Then display it in console application */

            double number = 81.7;
            Console.WriteLine(number);
            string myName = "Nour";
            Console.WriteLine(myName);
            char myFirstChar = 'N';
            Console.WriteLine(myFirstChar);
            bool myLastChar = false;
            Console.WriteLine(myLastChar);
            int myCount = 1;
            Console.WriteLine(myCount);
            const int myCount2 = 2;
            Console.WriteLine(myCount2);

            Console.WriteLine();
            Console.WriteLine("*******************answer3***********************");
            //3-	Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
            string[] car = new string[] { "KIA", "TOYOTA", "BMW", "Mercedese", "Mercobishi", "Mitsubishi" };
            Console.WriteLine(car.Length);

            Console.WriteLine();
            Console.WriteLine("*******************answer4***********************");
            //-----------------------------------------------Q4------------------------------------------------------------
            /*   4-	Write a program in C that reads a first name, surname and year of birth 
            and display the names and the year one after another sequentially. Go to the editor
        •	Input your firstname: Sami
        •	Input your lastname: Ali
        •	Input your year of birth: 1999
        •	Sami Ali 1999 */
            Console.Write("Input your firstname: ");
            string firstName = Console.ReadLine();
            Console.Write("Input your surname: ");
            string surName = Console.ReadLine();
            Console.Write("Input your year of birth: ");
            int year = int.Parse( Console.ReadLine());
            Console.WriteLine(firstName +" "+surName+" "+year);


            Console.WriteLine();
            Console.WriteLine("*******************answer5***********************");
            /*   5-	Write a program in C # to store elements in an array and print it. 
            •	Test Data :	
            •	Input 10 elements in the array :
            •	element - 0 : 1
            •	element - 1 : 1
            •	element - 2 : 2
            •	.......
            •	Expected Output :
            •	Elements in array are: 1 1 2 3 4 5 6 7 8 9  */
            int[] arr1 = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            Console.Write("Elements in array are: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("*******************answer6***********************");

            /*   6-	 Write a program in C# to find the sum of all elements of the array.
            •	Test Data :
            •	index - 0 : 2
            •	index - 1 : 5
            •	index - 2 : 8
            •	Expected Output :
            Sum of all elements stored in the array is : 15 */
            int[] arr2 = { 4, 2, 5, 3, 7 };
            Console.Write("Sum of all elements stored in the array is : ");
            Console.WriteLine(arr2.Sum());


        }
    }
}
