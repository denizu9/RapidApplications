internal class Program
{
    private static void Main(string[] args)
    {

        string[] courseNames = new string[] {"C#", "Java", "React", "Python"};

        for (int course = 0; course < courseNames.Length; course++)
        {
            Console.WriteLine(courseNames[course]);
        }   
    }
}