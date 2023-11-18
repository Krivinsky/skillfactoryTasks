namespace Example15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniqueSymbols();

            var softwareManufacturers = new List<string>()
            {
                "Microsoft", "Apple", "Oracle"
            };

            var hardwareManufacturers = new List<string>()
            {
               "Apple", "Samsung", "Intel"
            };

            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);


        }

        //15.1.4  Напишите метод для поиска общих букв в двух словах.
        public static IEnumerable<char> GetCommonLetters(string input1, string input2)
        {
            return input1.ToCharArray().Intersect(input2.ToCharArray());
        }


        //Задание 15.1.6
        //Напишите программу, которая будет принимать на вход строку текста с консоли
        //(конструкция Console.Readline()) и выводить в ответ список содержащихся
        //в строке уникальных символов без пробелов и следующих знаков препинания: , . ; :  ? !.

        public static void UniqueSymbols()
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            string except = ",.;: ?!";

            var result = input.ToCharArray().Distinct().Except(except);

            foreach (char c in result)
            {
                Console.WriteLine(c);
            }
        }
    }
}