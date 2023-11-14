
string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

var wordsInfo = from w in words
                orderby w.Length
                select new
                {
                    Name = w,
                    Length = w.Length,
                };

var wordsInfo2 = words.Select(w => new
{
    Name = w,
    Length = w.Length,
}).OrderBy(w => w.Length);

foreach (var word in wordsInfo)
    Console.WriteLine($"{word.Name} - {word.Length} букв");

Console.WriteLine();

foreach (var word in wordsInfo2)
    Console.WriteLine($"{word.Name} - {word.Length} букв");

Console.WriteLine();
//#########################################################################################

List<Student> students = new List<Student>
{
   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
};


var applications = from s in students
                   let age = DateTime.Now.Year - s.Age
                   where s.Age < 27
                   select new Application()
                   {
                       Name = s.Name,
                       YearOfBirth = age,
                   };

foreach (var studApplication in applications)
    Console.WriteLine(studApplication.Name + ", " + studApplication.YearOfBirth);

Console.WriteLine();
//###########################################################################################

// Список студентов
var studentsList = new List<Student>
{
   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
};

// Список курсов
var coarses = new List<Coarse>
{
   new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
   new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
};

var studentsWithCoarses = from student in studentsList
                          from coarse in coarses
                          select new { Name = student.Name, CoarseName = coarse.Name };

foreach (var stud in studentsWithCoarses)
    Console.WriteLine($"Студент {stud.Name} добавлен курс {stud.CoarseName}");
Console.WriteLine();
//############################################################################


var newStudents = from s in studentsList
                  where s.Age < 29 && s.Languages.Contains("английский")
                  let birthYear = DateTime.Now.Year - s.Age
                  from coarse in coarses
                  where coarse.Name.Contains("C#")
                  select new { Name = s.Name, YearOfBirth = birthYear, CoarseName = coarse.Name };

foreach (var stud in newStudents)
    Console.WriteLine($"Студент {stud.Name} ({stud.YearOfBirth}) добавлен курс {stud.CoarseName}");


public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
}


public class Application
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
}

class Coarse
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
}