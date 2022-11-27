// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void sumRec(int M, int N, int sum)
{
    if (N < 1 || M < 1)
    {
        return;
    }
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return ;
    }
    else
    {
        sum = sum + (M++);
        sumRec(M, N, sum);
    }

}

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
sumRec(M, N, 0);
