/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

// HomeWork 9
/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
/*
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M > N)
    for (int i = N; i <= M; i++)
        Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");
Console.WriteLine();
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int summ = 0;
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M > N)
{
    for (int i = N; i <= M; i++)
    {
        Console.Write($" {i}");
        summ += i;
    };
}
else
{
    for (int i = M; i <= N; i++)
    {
        Console.Write($" {i}");
        summ += i;
    }
}

Console.WriteLine();
if (M > N)
    Console.Write($" Сумма натуральных чисел между  N = {N} и M = {M} это {summ}");
else
    Console.Write($" Сумма натуральных чисел между  M = {M} и N = {N} это {summ}");
Console.WriteLine();
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/
/*
int Akk(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Akk(M - 1, 1);
    if (M > 0 && N > 0) return Akk(M - 1, Akk(M, N - 1));
    return Akk(M, N);
}
Console.WriteLine(Akk(3,2));
*/