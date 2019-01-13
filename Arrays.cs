using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int grade1 = ...
            //int grade2 = 


            //int[] gardes = { 1, 2, 4 }; // size 3
            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 4;


            //Console.Write("Enter number of students:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] myGrades = new int[size]; // dynamic

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter grade for student {i}:");
            //    int theGrade = Convert.ToInt32(Console.ReadLine());
            //    myGrades[i] = theGrade;
            //}

            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    sum = sum + myGrades[i];
            //}
            //double avg = sum / size;

            //int avg = CalcAvg(myGrades, size);

            int[] arr2 = { 5, 7, 9 };
            ModifyFirst(arr2);
            Console.WriteLine(arr2[0]);

            int[,] matrix = new int[5, 3];
            int[,] matrix2 =
            {
                { 7, 8, 9 },
                { 9, 6, 4 },
                { 8, 6, 5 },
                { 6, 5, 4 }
            };

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.WriteLine(matrix2[i, j]);
                }

            }

            Console.WriteLine(matrix2[3, 2]);
        }

        private static void ModifyFirst(int[] arr)
        {
            //arr[0] = 1;
            arr = new int[3];
            arr[0] = -100;
        }

        private static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        private static int CalcAvg(int[] arr, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + arr[i];
            }
            int avg = sum / size;

            return avg;
        }
    }
}
