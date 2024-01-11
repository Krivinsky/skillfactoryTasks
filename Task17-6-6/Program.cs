namespace Task17_6_6
{
    public class Program
    {
        static void Main(string[] args)
        {

            BasicAccount regularAccount = new RegularAccount
            {
                Type = "Обычный",
                Balance = 1100
            };

            SalaryAccount salaryAccount = new SalaryAccount
            {
                Type = "Зарплатный",
                Balance = 1500
            };

            Console.WriteLine($"Процентная ставка обычного аккаунта - {Calculator.CalculateInterest(regularAccount)} %");
            
            Console.WriteLine($"Процентная ставка зарплатного аккаунта - {Calculator.CalculateInterest(salaryAccount)} %");
        }
    }
}
