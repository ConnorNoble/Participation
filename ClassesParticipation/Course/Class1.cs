using System;

namespace Course
{
    public class Class1
    {
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }

        private string Test;

        public void setTest(string Test)
        {
            this.Test = Test;
        }
        public string getTest ()
            {
            return Test;
            }
        public Course()
        {
            CourseID = 0;
            CourseNumber = 0;
            CourseName = string.Empty;
            Subject = string.Empty;
            Instructor = string.Empty;
            Test = "";
        }
        public Course (string instructor, int id, string name, int number, string subject)
        {

        }
        public override string ToString()
        {
            return $ "{CourseID}{CourseName}{Subject}{"
            return base.ToString();
        }
    }
}
