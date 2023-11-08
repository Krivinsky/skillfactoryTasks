using System.Collections;

var months = new[]
{
   "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
};

var numbers = new[]
{
   1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
};


ArrayList arrayList = new ArrayList();

for (int i = 0; i < months.Length; i++)
{
    arrayList.Add(months[i]);
    arrayList.Add(numbers[i]);
}

foreach (object i in arrayList)
{
    Console.Write(i + " ");
}