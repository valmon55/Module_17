namespace Patters.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nameById = new NameByID();

            nameById.GetName(new Month(), 7);
            nameById.GetName(new Month(), 15);

            Console.WriteLine();

            nameById.GetName(new WeekDay(), 7);
            nameById.GetName(new WeekDay(), 0);

            Console.ReadKey();
        }
    }
}