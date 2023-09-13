class HomeWork
{
    static void Main(string[] args)
    {
        var data = GetData();
        OutputData(data);
    }

    private static (string name, string surName, int age, bool havePet, int countPets, int countFavColors, string[] favColors) GetData()
    {
        (string name, string surName, int age, bool havePet, int countPets, int countFavColors, string[] favColors) user = ("", "", 0, false, 0, 0, null);

        Console.WriteLine("Введите имя");
        user.name = Console.ReadLine();
        
        Console.WriteLine("Введите фамилию");
        user.surName = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("Введите возраст");
            int age = int.Parse(Console.ReadLine());
            if (InputValidation(age))
            {
                user.age = age;
                break;
            }
        }

        Console.WriteLine("У вас есть питомец (да/нет)");
        string answer = Console.ReadLine();
        if (answer.Equals("да"))
        {
            user.havePet = true;
            while (true)
            {
                Console.WriteLine("Введите количество питомцев");
                int countPets = int.Parse(Console.ReadLine());
                if (InputValidation(countPets))
                {
                    user.countPets = countPets;
                    break;
                }
            }
        }
        else user.havePet = false;

        while (true)
        {
            Console.WriteLine("Введите количество любимых цветов");
            int countFavColors = int.Parse(Console.ReadLine());
            if (InputValidation(countFavColors))
            {
                user.countFavColors = countFavColors;
                user.favColors = GetFavColors(user.countFavColors);
                break;
            }
        }

        return user;
    }

    static string[] GetFavColors(int countFavColors)
    {
        string[] favColors = new string[countFavColors];

        for (int i = 0; i < favColors.Length; i++)
        {
            Console.WriteLine("Введите любимый цвет");
            favColors[i] = Console.ReadLine();
        }
        return favColors;
    }

    static bool InputValidation(int number)
    {
        if (number > 0)
        {

            return true;
        }
        else
        {
            Console.WriteLine("Введено некоректное значение");
            return false;
        }
    }

    static void OutputData ((string name, string surName, int age, bool havePet, int countPets, int countFavColors, string[] favColors) user)
    {
        Console.WriteLine(" ******* Вывод данных ******* ");
        Console.WriteLine("Имя: " + user.name + "\nФамилия: " + user.surName + "\nВозраст: " + user.age);
        if (user.havePet) Console.WriteLine("количество питомцев: " + user.countPets);

        Console.WriteLine("любимые цвета");
        if (user.countFavColors > 0)
        {
            foreach (string str in user.favColors)
            {
                Console.WriteLine(str);
            }
        }
    }
}
