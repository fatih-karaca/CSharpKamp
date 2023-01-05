using System;

namespace _07GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Fatih");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}