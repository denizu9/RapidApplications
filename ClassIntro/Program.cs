internal class Program
{
    private static void Main(string[] args)
    {
        Course course1 = new Course();
        course1.courseName = "C#";
        course1.instructor = "Engin Demiroğ";
        course1.watchCount = 3200;

        Course course2 = new Course();
        course2.courseName = "Java";
        course2.instructor = "Engin Demiroğ";
        course2.watchCount = 5000;

        Course course3 = new Course();
        course3.courseName = "Python";
        course3.instructor = "Emre Geçen";
        course3.watchCount = 2790;

        Course[] courseList = new Course[] {course1, course2, course3};

        foreach (Course course in courseList)
        {
            Console.WriteLine(course.courseName + " : " + course.instructor + " , " + " Watch Count : " + " " + course.watchCount);
        }


    }

    class Course
    {
        public string courseName { get; set; }
        public string instructor { get; set; }
        public int watchCount { get; set; }
    }
}