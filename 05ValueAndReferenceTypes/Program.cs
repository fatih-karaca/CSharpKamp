using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _04ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;

            num1 = num2;
            num2 = 65;

            Console.WriteLine(num1);

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 1000, 2000, 3000 };
            
            numbers1= numbers2;
            numbers2[0] = 14;

            Console.WriteLine(numbers1[0]);
        }
    }
}
