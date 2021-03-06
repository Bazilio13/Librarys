using System;

namespace Librarys
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySizeI = 4;
            int arraySizeJ = 3;
            int [] array;
            int result;
            //array = Arrays2Demrnsioned.FillArray(arraySizeI, arraySizeJ);
            //Arrays2Demrnsioned.Print(array);
            //result = Arrays2Demrnsioned.FindMinNumber(array);
            //Console.WriteLine(Arrays2Demrnsioned.CountBiggerNummbers(array));
            //Arrays2Demrnsioned.Print(Arrays2Demrnsioned.TransposeArray(array));
            //Arrays1Demensional.PrintArray(Cycles.GetDivisibleNumbers(10,0));
            //array = Cycles.GetNumbersWithSumOfEvenMoreThenSumOfOdd(25);
            Console.WriteLine(Cycles.CheckMatchOfNumbers(1111411,-2207));
            //Arrays1Demensional.PrintArray(Cycles.GetNumbersWithSumOfEvenMoreThenSumOfOdd(25));

        }
    }
}
