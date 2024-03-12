internal class Program
{
    private static void Main(string[] args)
    {
        Course course1 = new Course();
        course1.courseName = "C#";
        course1.instructor = "Engin Demiroğ";
        course1.watchCount = 3200;

        Console.WriteLine("Course Name : " + " " + course1.courseName + ", " + "Instructor : " + " " + course1.instructor 
            + ", " + "Watch Count : " + " " + course1.watchCount);
    }

    class Course
    {
        public string courseName { get; set; }
        public string instructor { get; set; }
        public int watchCount { get; set; }
    }
}