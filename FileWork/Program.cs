class FileWriter
{
    //static void Main(string[] args)
    //{
    //    string filePath = @"C:\Users\Eugene\source\repos\skillfactory_tasks\FileWork\Program.cs";
    //    AddTextToFile(filePath);
    //    ReadProgramFile(filePath);
    //}

    public static void AddTextToFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("Последний запуск" + DateTime.Now);
            }
        }
    }

    public static void ReadProgramFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}