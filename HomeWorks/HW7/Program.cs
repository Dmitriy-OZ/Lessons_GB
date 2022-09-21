// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Home work 7

/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
void Print2DArray(double [,] Array2D)
{
for (int i = 0; i < Array2D.GetLength(0); i++)
        {   
            Console.Write($"");
            for (int j = 0; j < Array2D.GetLength(1); j++)
            {    
                Console.Write($"{Array2D[i, j]:f2}   ");
            }
            Console.WriteLine($"\b\b");
        }
        Console.WriteLine();
}

double[,] CreateNewRNDArray(int n, int m, int minValue, int maxValue)
{
    double[,] arr = new double[n, m];
    Random rng = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            arr[i, j] = rng.Next(minValue, maxValue) + rng.NextDouble();
    return arr;
}

Console.Clear();
Console.Write("Quantity of rows: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value for element of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value for element of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[,] new2DArray = CreateNewRNDArray(lines, columns, minValue, maxValue);
Print2DArray(new2DArray);
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
void Print2DArray(double [,] Array2D)
{
for (int i = 0; i < Array2D.GetLength(0); i++)
        {   
            Console.Write($"");
            for (int j = 0; j < Array2D.GetLength(1); j++)
            {    
                Console.Write($"{Array2D[i, j]:f2}   ");
            }
            Console.WriteLine($"\b\b");
        }
        Console.WriteLine();
}

double[,] CreateNewRNDArray(int n, int m, int minValue, int maxValue)
{
    double[,] arr = new double[n, m];
    Random rng = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            arr[i, j] = rng.Next(minValue, maxValue) + rng.NextDouble();
    return arr;
}

Console.Clear();

Random rng = new Random();
double[,] new2DArray = CreateNewRNDArray(rng.Next(3, 10), rng.Next(3, 10), rng.Next(1, 40), rng.Next(41, 99));

Console.Write("Number of i: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Number of j: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Print2DArray(new2DArray);

Console.WriteLine();

if (new2DArray.GetLength(0) > lines && new2DArray.GetLength(1) > columns)
        Console.Write($" {Convert.ToString(Math.Round(new2DArray[lines-1, columns-1],2))}");
    else
        Console.Write($" Нет такого значения в этом массиве");

Console.WriteLine();
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
void Print2DArray(int[,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(0); i++)
    {
        Console.Write($"");
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            Console.Write($"{Array2D[i, j]}   ");
        }
        Console.WriteLine($"");
    }
    Console.WriteLine("---------------------------------------");
}

int[,] CreateNewRNDArray(int n, int m, int minValue, int maxValue)
{
    int[,] arr = new int[n, m];
    Random rng = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            arr[i, j] = rng.Next(minValue, maxValue);
    return arr;
}


Console.Clear();

Random rng = new Random();
int[,] new2DArray = CreateNewRNDArray(rng.Next(3, 10), rng.Next(3, 10), rng.Next(1, 40), rng.Next(41, 99));
Print2DArray(new2DArray);

int []sum=new int [new2DArray.GetLength(1)];

for (int i=0; i< new2DArray.GetLength(1); i++)
{
    for(int j = 0; j < new2DArray.GetLength(0); j++)
    {
        sum[i] += new2DArray[j, i];
    }
}

for (int i=0; i<new2DArray.GetLength(1); i++)
{
    Console.Write(Convert.ToDouble(sum[i] / new2DArray.GetLength(0))  + "   ");
}
Console.WriteLine();
*/