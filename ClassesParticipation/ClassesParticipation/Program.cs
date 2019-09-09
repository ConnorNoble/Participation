using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();
            c.setTest("hello");
            var whatsTheValue = c.GetTest();
            c.Instructor = "Adam Ackerman";
            c.courseID = 1;
            c.CourseName = "Non Procedural programming ";
            c.courseNumber = 3033;
            c.Subject = "MIS";
            Console.WriteLine(c.CourseID + " " + c.CourseName);
            Console.WriteLine(c);

            Course c2 = new Course ("Adam Ackerman",1,"Introduction to Programming", 3013, "MIS")
        

            Console.WriteLine(whatsTheValue);

            Console.ReadKey();
        }
    }
}
