namespace Task
{
    class Program
    {
        static string filePath  = @"C:\Users\Eugene\source\repos\skillfactory_tasks\Task_13_1_6\text.txt";

        static void Main(string[] args)
        {
            AnotherGetWord();
            if (File.Exists(filePath))
            {
                Console.WriteLine(GetWordFromFile(filePath));
            }
        }

        public static void AnotherGetWord ()
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText(@"C:\Users\Eugene\source\repos\skillfactory_tasks\Task_13_1_6\text.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine(words.Length);
        }

        public static int GetWordFromFile(string filePath)
        {
            List<string> list = new List<string>();
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = string.Empty;
                while ((str = sr.ReadLine()) != null)
                {
                    if (str != string.Empty)
                    {
                        string[] stings = str.Split(' ', '\r', '\n');
                        list.AddRange(stings);
                    }
                }
            }
            return list.Count;
        }
    }
}