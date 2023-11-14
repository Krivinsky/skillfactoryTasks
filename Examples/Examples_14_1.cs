using System;
using System.Linq;

string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

var selectedPeople = from p  in people
                     where p.StartsWith("А")
                     orderby p
                     select p;

foreach (var person in selectedPeople)
{
    Console.WriteLine(person);
}

var objects = new List<object>()
{
   1,
   "Сергей ",
   "Андрей ",
   300,
};


var result = objects.Where(x => x is string).OrderBy(x => x as string).ToList();
foreach (var person in result)
{
    Console.WriteLine(person);
}
