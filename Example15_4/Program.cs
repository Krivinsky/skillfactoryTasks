namespace Example15_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var departments = new List<Department>()
            {
                new Department() {Id = 1, Name = "Программирование"},
                new Department() {Id = 2, Name = "Продажи"}
            };


            var employees = new List<Employee>()
            {
                new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var result = from e in employees
                         join d in departments on e.DepartmentId equals d.Id
                         select new
                         {
                             Name = e.Name,
                             Id = e.Id,
                             DepartmentName = d.Name
                         };

            var result2 = employees.Join(departments,
                e => e.DepartmentId,
                d => d.Id,
                (e, d) =>
                new
                {
                    Name = e.Name,
                    Id = e.Id,
                    DepartmentName = d.Name
                });

            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Id} ({item.DepartmentName})");

            Console.WriteLine("*****************************************************");

            foreach (var item in result2)
                Console.WriteLine($"{item.Name} - {item.Id} ({item.DepartmentName})");

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------");


            var resultGroup = departments.GroupJoin(
                employees,
                d => d.Id,
                e => e.DepartmentId,
                (d, emp) => new
                {
                    Name = d.Name,
                    Employes = emp.Select(e => e.Name)
                });
        }
    }



    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public int DepartmentId { get; set; }
        
        public string Name { get; set; }

        public int Id { get; set; }
    }
}