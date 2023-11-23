

namespace Example_15
{
    public class Program
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


            var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 79994500508 },
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675334 },
                new Contact() { Name = "Игорь", Phone = 8884994 },
                new Contact() { Name = "Анна", Phone = 665565656 },
                new Contact() { Name = "Василий", Phone = 3434 }
            };

            //Посчитайте, у скольких из них неверные номера телефонов (верный телефон содержит 11 цифр и начинается с семёрки).

            var rightContact = 
               (from contact in contacts
                let str = contact.Phone.ToString()
                where str.StartsWith('7') && str.Length == 11
                select contact)
                .Count();


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