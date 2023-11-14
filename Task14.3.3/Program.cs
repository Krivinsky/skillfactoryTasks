namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            IEnumerable<Contact> contacts = null;
            string input;
            do
            {
                Console.WriteLine("введите номер страницы телефонного справочника или 0 для выхода");
                input = Console.ReadLine();
                bool parsed = int.TryParse(input, out int pageNumber);

                if (parsed && pageNumber >= 1 && pageNumber <= 3)
                {
                    contacts = phoneBook
                        .Skip((pageNumber - 1)*2)
                        .Take(2).OrderBy( s => s.Name)
                        .ThenBy(s => s.LastName);

                    foreach (var entry in contacts)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);
                    
                    Console.WriteLine();

                } else
                {
                    if (pageNumber == 0)
                    {
                        Console.WriteLine("выход");
                    }
                }

            }
            while (input != "0");
        }
    }
    public class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}