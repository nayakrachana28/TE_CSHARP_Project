using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSHARP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            //instance created for non static method
            Program c = new Program();
            c.condition();
            Console.WriteLine("---------------------------------------------");

            arrayone();
        }

        public void condition()
        {
            Console.WriteLine("Enter the number");
            int value = Convert.ToInt32(Console.ReadLine());
            //string val = Console.ReadLine();
            //Console.WriteLine($"{val}");
            //Console.WriteLine("Name is {0} ", val);
            //Console.WriteLine("Name is" + val);
            if (value % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        public static void arrayone()
        {
            int size;
            Console.WriteLine("Enter the size of an array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] array3 = new int[] { };
            int[] array4 = new int[size];
            int[] array2 = { };

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the value of {0} array", (i + 1));
                array4[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Display the array details using for loop");
            Console.WriteLine("Array elements are");
            for (int j = 0; j < size; j++)
            {
                Console.WriteLine("Array index {0} value is {1}", (j + 1), array4[j]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Display the array details using for each");
            foreach (int v in array4)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Enter the operator(+,-,/) and the value a and b");
            Console.WriteLine("Enter the operator");
            char opertaors=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the first value");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound value");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (opertaors)
            {
                case '+':int s = a + b; 
                    Console.WriteLine("Added value is "+s);
                    break;
                case '-':
                    int v = a - b;
                    Console.WriteLine("Subtracted value  " + v);
                    break;
                default:Console.WriteLine("Enter the correct operator mentioned please");
                    break;
            }

        }

    }
}
