// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var contacts = new List<Contact>()
{
   new Contact() { Name = "Андрей", Phone = 7999945005 },
   new Contact() { Name = "Сергей", Phone = 799990455 },
   new Contact() { Name = "Иван", Phone = 79999675 },
   new Contact() { Name = "Игорь", Phone = 8884994 },
   new Contact() { Name = "Анна", Phone = 665565656 },
   new Contact() { Name = "Василий", Phone = 3434 }
};

while (true)
{
    string str = Console.ReadLine();

    IEnumerable<Contact> contactPage = null;

    switch (str) {
        case "1":
            contactPage = contacts.Take(2);
            break;

        case "2":
            contactPage = contacts.Skip(2).Take(2);
            break;

        case "3":
            contactPage = contacts.Skip(4).Take(2);
            break;

        default:
            Console.WriteLine("Введено не верное число");
            break;
    }

    foreach (Contact contact in contactPage)
    {
        Console.WriteLine($"{contact.Name} - {contact.Phone} ");
    }
    
}

// Подготовка данных
var cars = new List<Car>()
{
   new Car("Suzuki", "JP"),
   new Car("Toyota", "JP"),
   new Car("Opel", "DE"),
   new Car("Kamaz", "RUS"),
   new Car("Lada", "RUS"),
   new Car("Lada", "RUS"),
   new Car("Honda", "JP"),
};

Console.WriteLine("Пропустим японские машины в начале списка");
var notJapanCars = cars.SkipWhile(car => car.CountryCode == "JP");

foreach (var notJapanCar in notJapanCars)
    Console.WriteLine(notJapanCar.CountryCode);

Console.WriteLine();

var notJapans = cars.RemoveAll(car => car.CountryCode == "JP");







class Contact
{
    public string Name { get; set; }

    public long Phone { get; set; }
}


class Car
{
    public string Name { get; set; }

    public string CountryCode { get; set; }

    public Car(string name, string countryCode)
    {
        Name = name;
        CountryCode = countryCode;
    }
}
