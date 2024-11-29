internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, result;
        Console.WriteLine("Введите число 1");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число 2");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите действие");
        ConsoleKey consoleKey = Console.ReadKey().Key;
        switch (consoleKey)
        {
            case ConsoleKey.OemPlus:
                result = a + b;
                Console.WriteLine(result);
            default:
                break;
        }
    }
}