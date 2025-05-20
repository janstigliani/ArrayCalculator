using System.Security.AccessControl;

namespace ArrayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "22 10,2 24,7 3,10";
            var calc = new Calculator(input);

            Console.WriteLine(calc.Sum());
            Console.WriteLine(calc.Avg());
            Console.WriteLine(calc.Max());
        }

    }
}
