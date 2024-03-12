internal class Program
{
    private static void Main(string[] args)
    {

        string[] courseNames = new string[] {"C#", "Java", "React", "Python"};

        for (int i = 0; i < courseNames.Length; i++)
        {
            Console.WriteLine(courseNames[i]);
        }

        foreach (string course in courseNames)
        {
            Console.WriteLine(course);
        }
    }
}