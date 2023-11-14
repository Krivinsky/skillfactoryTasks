
// Подготовим данные
List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

// нужно получить тех, кто младше 28 лет и владеет английским языком: 

// Составим запрос 
var selectedStudents = students.SelectMany( 

        s => s.Languages,    // коллекция, которую нужно преобразовать

        (s, l) => new { Student = s, Lang = l })  // функция преобразования, применяющаяся к каждому элементу коллекции
        
        .Where(s => s.Lang == "английский" && s.Student.Age < 28)  // дополнительные условия
        
        .Select(s => s.Student);   // указатель на объект выборки


// Выведем результат
foreach (Student student in selectedStudents)
    Console.WriteLine($"{student.Name} - {student.Age}");


//-----------------------------------------------------------------------------------------------


var companies = new Dictionary<string, string[]>();

companies.Add("Apple", new[] { "Mobile", "Desktop" });
companies.Add("Samsung", new[] { "Mobile" });
companies.Add("IBM", new[] { "Desktop" });


var mob = from compani in companies
          from m in compani.Value
          where m == "Mobile"
          select compani;

var mob2 = companies.Where(x => x.Value.Contains("Mobile"));

foreach (var m in mob)
{
    string[] s = m.Value;
    foreach (var s2 in s)
    {
        Console.WriteLine(s2);
    }
    Console.WriteLine();
}


//--------------------------------------------------------------------------------------------


var numsList = new List<int[]>()
{
   new[] {2, 3, 7, 1},
   new[] {45, 17, 88, 0},
   new[] {23, 32, 44, -6},
};

var nums = numsList.SelectMany(x => x).OrderBy(x => x);

foreach (var ord in nums)
    Console.WriteLine(ord);



public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
}