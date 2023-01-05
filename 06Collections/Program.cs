using System;

namespace _06Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Fatih", "Kemal", "Engin", "Rauf"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            names.Add("Gökhan");
            Console.WriteLine(names[4]);


        }
    }
}