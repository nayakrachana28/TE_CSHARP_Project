using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSHARP
{
    internal class arrays_intro
    {
        /// <summary>
        /// array concepts
        /// </summary>
        public static void Main()
        {
            array_types();

        }

        public static void array_types()
        {
            //two-dimensional array
            /* 
             int[,] array1 =
            {
                {1,2,3},
                {4,5,6}
            };
            */
            int[,] array1 = new int[,]
            {
                {1,2,3},
                {4,5,6}
            };
            //GetLength is used to get the length
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine(array1[i, j]);
                }
            }

            int[][] array2 = new int[][]
            {
                new int[]{1,2,3},
                new int[] {4,5,6,7,8},
                new int[]{5,6,7,8,9}
            };

            Console.WriteLine("----------------------------------");

            for(int k = 0; k < array2.Length; k++)
            {
                for(int l = 0; l < array2[k].Length; l++)
                {
                    Console.Write(array2[k][l] +"\t");
                }
                Console.WriteLine("\n");    
            }


        }
    }
}
