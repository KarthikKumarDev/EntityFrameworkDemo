using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemo
{
    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoDbContext();
            
            context.UpdateCourse(25, "MyEdit", "Changed", "Beginner", 1);


            var courses = context.GetCourses();
            foreach (var c in courses)
            {
                //c.Level = Level.Beginner;
                Console.WriteLine(c.Title + ' '+ c.Level);
            }
            Console.Read();
        }
    }
}
