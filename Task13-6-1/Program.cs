using System.Diagnostics;

namespace Task13_6_1
{
    public class Program
    {
        static string filePath = @"C:\Users\Eugene\source\repos\skillfactory_tasks\Task_13_1_6\text.txt";

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            LinkedList<string> linkedList = new LinkedList<string>();
            
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText(@"C:\Users\Eugene\source\repos\skillfactory_tasks\Task13-6-1\Text.txt");
            
            string[] stings = text.Split(' ', '\r', '\n');

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            foreach (string str in stings)
            {
                if (str != string.Empty)
                {
                    list.Add(str);
                }
            }
            stopWatch.Stop();
            long ts = stopWatch.ElapsedTicks;

            Console.WriteLine($"Время затраченное на вставку в List  - {ts}");

            stopWatch.Start();
            foreach (string str in stings)
            {
                if (str != string.Empty)
                {
                    linkedList.AddFirst(str);
                }
            }
            stopWatch.Stop();
            ts = stopWatch.ElapsedTicks;

            Console.WriteLine($"Время затраченное на вставку в LinkedList  - {ts}");
        }
    }
}