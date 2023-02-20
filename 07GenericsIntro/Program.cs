using System;
using _07GenericsIntro;

namespace _07GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();
            numbers.Add(14);
            numbers.Add(3);
            numbers.Add(90);
            numbers.Add(19);

            Console.WriteLine(numbers.Length);
            Console.WriteLine("3. eleman : " + numbers.Items[2]);
            Console.WriteLine("4. eleman : " + numbers.Items[3]);

            foreach (var number in numbers.Items)
            {
                Console.WriteLine(number);
            }
            
            //List<int> numbers = new List<int>();
            //numbers.Add(14);
            //numbers.Add(3);
            //numbers.Add(90);

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            Dictionary<int,string> dict = new Dictionary<int,string>();

            dict.Add(90, "Türkiye");
            dict.Add(994, "Azerbaycan");
            dict.Add(32, "Belçika");
            dict.Add(56, "Şili");
            dict.Add(358, "Finlandiya");

            Console.WriteLine($"358 telefon kodu : {dict[358]}");
            Console.WriteLine($"90 telefon kodu : {dict[90]}");
            Console.WriteLine($"56 telefon kodu : {dict[56]}");
        }
    }
}