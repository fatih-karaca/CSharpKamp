using System;
namespace _02ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Course course1 = new Course();
            course1.KursAdi = "C# ve ASP.NET Kursu";
            course1.Egitmen = "Engin Demiroğ";
            course1.IzlenmeOrani = 14;

            Course course2 = new Course();
            course2.KursAdi = "Python Kursu";
            course2.Egitmen = "Selami Kelle";
            course2.IzlenmeOrani = 43;

            Course course3 = new Course();
            course3.KursAdi = "Java Kursu";
            course3.Egitmen = "Fahrettin Koparır";
            course3.IzlenmeOrani = 27;

            Course course4 = new Course();
            course4.KursAdi = "C++ Kursu";
            course4.Egitmen = "Ragıp Kokariç";
            course4.IzlenmeOrani = 58;

            List<Course> courses = new List<Course>();
            courses.Add(course1);
            courses.Add(course2);
            courses.Add(course3);
            courses.Add(course4);

            foreach (var course in courses)
            {
                Console.WriteLine(course.KursAdi + " --- " + course.Egitmen);
            }
        }
    }

    class Course
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}