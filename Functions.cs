using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();


            PrintHelloWorld();

            int returnValue = ReadlineReturnNumberPower2();

            //Console.WriteLine( ReadlineReturnNumberPower2() );

            //bool biggerThan5 = returnValue > 5;

            //if (biggerThan5 || !AhadotBiggerAsarot(returnValue))
            //{

            //}

            //string text = "Hello World!";

            //string myName = GetMyName();
            //if (GetMyName() == "Itay")
            //{
            //    Console.WriteLine("Hello myself!");
            //}


            //int result = Divide2Numbers(5, 2);
            //int result1 = Divide2Numbers(5);
            //int result2 = Divide2Numbers(5, y : result);

            int a = 1;
            int b = 2;
            IncreaseAB(ref a, ref b);
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int x, y, z;
           
            GetXYZ(out x, out y, out z);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


        }

        private static void GetXYZ(out int x1, out int y1, out int z1)
        {
            Console.WriteLine("Enter X");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Z");
            z1 = Convert.ToInt32(Console.ReadLine());
        }
        private static void IncreaseAB(ref int x, ref int y)
        {
            x = x + 1;
            y = y + 1;
        }

        private static int Divide2Numbers(int x , int z = 1, int y = 1)
        {
            return x / y;
        }


        private static string GetMyName()
        {
            Console.WriteLine("Enter number, will be powered 2");
            string name = Console.ReadLine();

            return name;
        }

        private static bool AhadotBiggerAsarot(int x)
        {
            if (x % 10 > x / 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int ReadlineReturnNumberPower2()
        {
            Console.WriteLine("Enter number, will be powered 2");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = number * number;

            return result;
        }

        private static void Calculate3Power2()
        {
            
        }

        private static void PrintHelloWorld()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }

        private static void GoodBye()
        {
            Console.WriteLine("GoodBye");
        }
    }
}
