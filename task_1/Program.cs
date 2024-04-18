using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        string inputM = Console.ReadLine();
        int m;
        
        if (inputM != null && int.TryParse(inputM, out m))
        {
            Console.Write("Введите значение N: ");
            string inputN = Console.ReadLine();
            int n;
            
            if (inputN != null && int.TryParse(inputN, out n))
            {
                PrintNaturalNumbers(m, n);
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный формат числа для N.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Неверный формат числа для M.");
        }
    }

    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbers(m + 1, n);
        }
    }
}