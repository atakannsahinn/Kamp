namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Educator = "Engin Demiroğ";
            course1.Percentage = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Educator = "Atakan Şahin";
            course2.Percentage = 100;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Educator = "Angela Yu";
            course3.Percentage = 80;

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (Course course in courses)
            {
                Console.WriteLine("{0} - {1} - {2}% completed",course.CourseName, course.Educator, course.Percentage );
            }

        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Educator { get; set; }
        public int Percentage { get; set; }
    }
}