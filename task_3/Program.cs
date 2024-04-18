using System;

class Program
{
    static void Main()
    {
        // Произвольный массив
        int[] myArray = { 1, 2, 3, 4, 5 };

        // Вывод элементов массива в строку, начиная с конца, используя рекурсию
        Console.WriteLine(ReverseArrayToString(myArray, myArray.Length - 1));
    }

    static string ReverseArrayToString(int[] arr, int index)
    {
        if (index < 0)
            return "";

        return arr[index] + " " + ReverseArrayToString(arr, index - 1);
    }
}