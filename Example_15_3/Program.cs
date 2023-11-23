namespace Example_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            var phneBookByGroup = phoneBook.GroupBy(contact => contact.Email.Split("@").Last());

            foreach (var group in phneBookByGroup)
            {
                if (group.Key.Contains("example"))
                {
                    foreach (var contact in group)
                    {
                        Console.WriteLine(contact.Name + " " + contact.Email);
                    }
                } else
                {
                    foreach (var contact in group)
                    {
                        Console.WriteLine(contact.Name + " " + contact.Email);
                    }
                }
            }
                
        }


    }
}