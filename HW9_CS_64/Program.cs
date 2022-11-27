// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Recurtion(int n, int N)
{
    if (n < 1)
    {
        return;
    }
    if (n == N)
        Console.Write($"{n}");
    else

        Console.Write($", {n}");
    if (n > 1)
    {
        Recurtion(n - 1, N);
    }
    
}
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
Recurtion(N, N);
Console.WriteLine();

