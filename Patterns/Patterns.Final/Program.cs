namespace Patterns.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account salaryAccount = new Account();
            salaryAccount.Balance = 100;
            salaryAccount.Type = "Salary";
            salaryAccount.Interest  = Calculator.CalculateInterest(new SalaryProjectAccount(), salaryAccount);
            Console.WriteLine($"{salaryAccount.Interest}");

            Account usialAccount1 = new Account();
            usialAccount1.Balance = 100;
            usialAccount1.Type = "Usual";
            usialAccount1.Interest = Calculator.CalculateInterest(new UsialAccount(), usialAccount1);
            Console.WriteLine($"{usialAccount1.Interest}");

            Account usialAccount2 = new Account();
            usialAccount2.Balance = 1001; 
            usialAccount2.Type = "Usual";
            usialAccount2.Interest = Calculator.CalculateInterest(new UsialAccount(), usialAccount2);
            Console.WriteLine($"{usialAccount2.Interest}");

            Console.ReadKey();
        }
    }
}