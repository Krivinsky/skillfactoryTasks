using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWork
{
    class FileInfoWriter
    {
        static void Main(string[] args)
        {
            string tempFile = Path.GetTempFileName();
            var fileInfo = new FileInfo(tempFile);

            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine("Я");
                sw.WriteLine("Лучший");
                sw.WriteLine("программист)))))))");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }

            try
            {
                string tempFile2 = Path.GetTempFileName();
                var fileInfo2 = new FileInfo(tempFile2);

                fileInfo2.Delete();

                fileInfo.CopyTo(tempFile2);
                Console.WriteLine($"{tempFile} скопирован в файл {tempFile2}");

                fileInfo.Delete();
                Console.WriteLine($"{tempFile} удален");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }
        }
    }
}
