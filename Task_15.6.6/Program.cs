namespace Task15_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var result = from cla in classes
                         let std = cla.Students.ToArray()
                         from s in std
                         select s;

            return result.ToArray();
        }
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}