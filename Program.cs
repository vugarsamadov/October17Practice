using System;
using System.Reflection.Metadata;

namespace October17Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(printParity(12));

            //printPrimeFactors(12);

            //Console.WriteLine();

            //printPrimeFactors(12);

            //Console.WriteLine();

            //printUniquePrimeFactors(-12);

            quadrilateralArea(2);
            quadrilateralArea(3,4);
            quadrilateralArea(5,6,7);
        }

        static void quadrilateralArea(int a)
        {
            Console.WriteLine("Square area is: ", a * a);
        }
        static void quadrilateralArea(int a, int b)
        {
            Console.WriteLine("Rectangle area is: ", a * b);
        }
        static void quadrilateralArea(int longBase, int shortBase, int height)
        {
            Console.WriteLine("Trapezoid area is: ", 0.5 * (longBase * shortBase) * height);
        }


        //static float Sum(float a, float b) 
        //{
        //    return a + b;
        //}
        //static float Difference(float a, float b) 
        //{
        //    return a - b;
        //}
        //static float Multiplication (float a, float b) 
        //{
        //    return a * b;
        //}
        //static float Division(float a, float b) 
        //{
        //    return a / b;
        //}

        //static string printParity(int number)
        //{
        //    return number % 2 == 0 ? "Even" : "Odd";
        //}

        //static bool isPrime(int number)
        //{
        //    for (int i = 2; i < number; i++) 
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}

        //static void printPrimeFactors(int number)
        //{
        //    Console.Write(number+" -> ");
        //    int quotient = number;

        //    while(quotient!=1)
        //        for(int i = 2; i <= quotient; i++) 
        //            if( quotient%i==0)
        //            {
        //                Console.Write(i+" ");
        //                quotient /= i;
        //                break;
        //            }
        //}

        //static void printUniquePrimeFactors(int number)
        //{
        //    bool isMinus = number<0;
        //    if (isMinus)
        //        number*=-1;
           

        //    Console.Write(number + " -> ");
        //    int[] array = new int[number+1];

        //    int quotient = number;

        //    while (quotient != 1)
        //        for (int i = 2; i <= quotient; i++)
        //            if (quotient % i == 0)
        //            {
        //                array[i] = 1;
        //                quotient /= i;
        //                break;
        //            }

        //    for (int i =0;i<array.Length;i++)
        //        if(array[i]==1)
        //            Console.Write((isMinus?"-":"")+i+" ");

        //}

    

    }
}
