
var russianCities = new List<City>();
russianCities.Add(new City("Москва", 11900000));
russianCities.Add(new City("Санкт-Петербург", 4991000));
russianCities.Add(new City("Волгоград", 1099000));
russianCities.Add(new City("Казань", 1169000));
russianCities.Add(new City("Севастополь", 449138));

var bigCities = from c in russianCities
where c.Population > 1000000
orderby c.Population descending
select c;

var bigCities2 = russianCities.Where(x => x.Population > 1000000).OrderByDescending(x => x.Population);

foreach (var bigCity in bigCities)
Console.WriteLine(bigCity.Name + " - " + bigCity.Population);

Console.WriteLine("########################################");
foreach (var bigCity2 in bigCities2)
Console.WriteLine(bigCity2.Name + " - " + bigCity2.Population);

Console.WriteLine("\n");
var bigNamesCity = from r in russianCities
                   where r.Name.Length <= 10
                   orderby r.Name
                   select r;

foreach (var city in bigNamesCity)
    Console.WriteLine(city.Name);

Console.WriteLine();

var bigNamesCity2 = russianCities.Where(x => x.Name.Length <= 10).OrderByDescending(x => x.Name.Length);


foreach (var city in bigNamesCity2)
    Console.WriteLine(city.Name);


public class City
{
    public City(string name, long population)
    {
        Name = name;
        Population = population;
    }

    public string Name { get; set; }
    public long Population { get; set; }
}

