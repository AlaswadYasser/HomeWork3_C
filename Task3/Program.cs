// Задача 29: Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33] 

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Вводите Число Элементов Массива");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().Next(0, 999);

        Console.WriteLine($"[{string.Join(", ", array)}]");
    }
}