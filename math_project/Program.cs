namespace math_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pierwszą liczbę: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Wynik dodawania: {x + y}");

            Console.WriteLine($"Wynik odejmowania: {x - y}");

            Console.WriteLine($"Wynik mnozenia: {x * y}");

            Console.WriteLine($"Wynik dzielenia: {x / y}");

            Console.WriteLine($"Wynik modulo: {x % y}");

            Console.WriteLine($"Która liczba jest największa: {Math.Max(x,y)}");

            Console.WriteLine($"Która liczba jest najmniejsza: {Math.Min(x, y)}");

            Console.WriteLine($"Wynik potegowania: {Math.Pow(x, y)}");

            Console.WriteLine($"Wynik pierwiastkowania: {Math.Sqrt(x)}");

            Console.WriteLine($"zwróć dodatnią: {Math.Abs(x)}");

            Console.WriteLine($"Zaokrąglij {Math.Round(x)}");


        }
    }
}
