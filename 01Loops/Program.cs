using System;

namespace _01Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "C# ve .NET Framework Kursu";
            string course2 = "Java Kursu";
            string course3 = "HTML, CSS ve Javascript Kursu";
            string course4 = "Mobil Programlama Kursu";


            /* Bir LIST nesnesi tanımlayıp, bu kursları listeye ekleme. */
            
            List<string> courseList = new List<string>();
            courseList.Add(course1);
            courseList.Add(course2);
            courseList.Add(course3);
            courseList.Add(course4);

            foreach (var course in courseList)
            {
                Console.WriteLine("* " + course);
            }


            /* Bu kursları içerecek şekilde bir STRING ARRAY nesnesi tanımlama. */

            string[] courses = new string[] { course1, course2, course3, course4 };

            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine("- " + courses[i]);
            }
        }
    }
}