namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCountFiles();
            GetCatalogs(); //   Вызов метода получения директорий
            //CreateCatalog();
            DeleteCatalog();
            Console.WriteLine();
            GetCountFiles();
        }

        private static void DeleteCatalog()
        {
            DirectoryInfo directory = new DirectoryInfo(@"E:\new dir");
            directory.Delete(true);
        }

        private static void CreateCatalog()
        {
            DirectoryInfo directory = new DirectoryInfo(@"E:\new dir");
            if (!directory.Exists )
            {
                directory.Create();
            }
            directory.CreateSubdirectory("001");
        }

        private static void GetCountFiles()
        {
            string dirName = @"E:\";
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                Console.WriteLine(dirs.Length);

                string[] files = Directory.GetFiles(dirName);
                Console.WriteLine(files.Length);

                int count = dirs.Length + files.Length;
                Console.WriteLine(count);

            }
        }

        static void GetCatalogs()
        {
            string dirName = "E:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
            }
        }
    }
}