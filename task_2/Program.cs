using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

   static void Main(string[] args)
    {
        Console.Write("Введите значение m: ");
        int m;
        string input = Console.ReadLine();
        if (!int.TryParse(input, out m) || m < 0)
        {
            Console.WriteLine("Пожалуйста, введите неотрицательное целое число для m.");
            return;
        }

        Console.Write("Введите значение n: ");
        int n;
        input = Console.ReadLine();
        if (!int.TryParse(input, out n) || n < 0)
        {
            Console.WriteLine("Пожалуйста, введите неотрицательное целое число для n.");
            return;
        }

        int result = Ackermann(m, n);
        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");
    }
}
