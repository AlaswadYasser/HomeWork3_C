// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите Первый Число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ввидите Второй Число");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = 1;
        for (int i = 1; i<=b; i++)
        {
            c = c * a;
        }    
        
            Console.Write($"-> {c}");
    }
}