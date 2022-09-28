/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
//Home work 8
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
    Console.WriteLine();
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

int [,] SortLineInArray(int [,] new2DArray)
{
    int maxIndex, temp;
    for (int k = 0; k < new2DArray.GetLength(0); k++)
        for (int i = 0; i < new2DArray.GetLength(1); i++)
        {   
            maxIndex =  i;
            for (int j = i+1; j < new2DArray.GetLength(1); j++)
                if (new2DArray[k,j] > new2DArray[k, maxIndex])
                    maxIndex  = j;
            temp = new2DArray[k, maxIndex];
            new2DArray[k, maxIndex] = new2DArray[k, i];
            new2DArray[k,i] = temp;
    }
    return new2DArray;
}

Console.Clear();
Console.WriteLine();
Random rng = new Random();
int[,] new2DArray = CreateNewRNDArray(rng.Next(3, 10), rng.Next(3, 10), rng.Next(1, 40), rng.Next(41, 99));
Print2DArray(new2DArray);
Console.WriteLine();
//теперь надо упорядочить построчно по убыванию
int[,] Sort2DArray = SortLineInArray(new2DArray);
Print2DArray(Sort2DArray);
//*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
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
    Console.WriteLine();
}
*/
/*
int[,] CreateNewRNDArray(int n, int m, int minValue, int maxValue)
{
    int[,] arr = new int[n, m];
    Random rng = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            arr[i, j] = rng.Next(minValue, maxValue);
    return arr;
}
*/
/*
void ShowMinSumInLine(int[,] new2DArray)
{
    int SummInLine = 0;
    int SummInLineTemp = 0;
    int NumberMinLine = 0;
    for (int i = 0; i < new2DArray.GetLength(0); i++)
    {
        //SummInLineTemp = SummInLine;
        SummInLine = 0;

        for (int j = 0; j < new2DArray.GetLength(1); j++)
        {
            SummInLine += new2DArray[i, j];
        }
        if (i == 0)
            SummInLineTemp = SummInLine;
        else if (SummInLineTemp > SummInLine)
        {
            SummInLineTemp = SummInLine;
            NumberMinLine = i;    
        }
        Console.WriteLine($" Sum of line is {SummInLine}");
    }
    Console.WriteLine($" MIN sum of line is {SummInLineTemp} in line {NumberMinLine + 1}");
}

Console.Clear();
Console.WriteLine();
Random rng = new Random();
int LineColo = rng.Next(3, 10);
int[,] new2DArray = CreateNewRNDArray(LineColo, LineColo, rng.Next(1, 40), rng.Next(41, 99));
//int[,] new2DArray = CreateNewRNDArray(3, 3, rng.Next(1, 40), rng.Next(41, 99));
Print2DArray(new2DArray);
Console.WriteLine();
ShowMinSumInLine(new2DArray);

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int [,] MultiplayArray(int[,] arr1, int [,] arr2)
{
    int sum =0;
    int [,] res = new int [arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) != arr2.GetLength(0))
        return res;
    for (int i = 0; i < res.GetLength(0); i++)
        for (int j = 0; j < res.GetLength(1); j++)
            for (int k = 0; k < arr2.GetLength(0); k++)
                res[i,j] += arr1[i,k]*arr2[k,j];
    return res;                
}

Console.Clear();

Console.WriteLine();
Random rng = new Random();
int LineColo = rng.Next(2, 4);
int[,] new2DArray1 = CreateNewRNDArray(LineColo, LineColo, rng.Next(1, 40), rng.Next(41, 99));
int[,] new2DArray2 = CreateNewRNDArray(LineColo, LineColo, rng.Next(1, 40), rng.Next(41, 99));
//int[,] new2DArray = CreateNewRNDArray(3, 3, rng.Next(1, 40), rng.Next(41, 99));
Console.WriteLine("First array: ");
Print2DArray(new2DArray1);
Console.WriteLine("Second array: ");
Print2DArray(new2DArray2);
   
int [,] newArrOfX = MultiplayArray(new2DArray1, new2DArray2);
Print2DArray(newArrOfX);
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
////////////////////////////
/*
int[,,] CreateMatrix(int line, int column, int dep, int min, int max)
{
    int[,,] matrix = new int[line, column, dep];
    Random rnd = new Random();

    bool numisfind = true; //число уже использовалось

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
                while (numisfind)
                {
                    for (int a = 0; a < matrix.GetLength(0); a++)
                    {
                        for (int b = 0; b < matrix.GetLength(1); b++)
                        {
                            for (int c = 0; c < matrix.GetLength(2); c++)
                                if (matrix[i, j, k] == matrix[a, b, c])
                                {
                                    matrix[i, j, k] = rnd.Next(matrix[i, j, k]-1, max + 1);
                                }
                                else
                                {
                                    numisfind = false;
                                    break;
                                }
                        }
                    }
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"| {matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.Write(" |");
            Console.WriteLine();
        }
    }
}

int[,,] array3D = CreateMatrix(2, 2, 2, 10, 99);
PrintMatrix(array3D);
*/
////////////////////////////
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/*
int N = 4, M = 4;
int[,] Array = new int[N, M];

int line = 0, column = 0, d_x = 1, d_y = 0, dirChanges = 0, stop = M;

for (int i = 0; i < Array.Length; i++)
{
    Array[column, line] = i + 1;
    if (--stop == 0)
    {
        stop = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = d_x;
        d_x = -d_y;
        d_y = temp;
        dirChanges++;
    }
    column += d_y;
    line += d_x;
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(Array[i, j].ToString("00.##") + " ");
    }
    Console.WriteLine();
}
*/

