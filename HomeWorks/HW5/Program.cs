/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

//Home work 5

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int NewRandomArray(int SizeArray)
{
    int[] array = new int[SizeArray];
    Random rand = new Random();
    int NumberOfEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(100, 999); 
            Console.Write($" {array[i]}");
            if (array[i]%2 == 0)
            {
                NumberOfEvenNumbers++;
            }
        }   
    return NumberOfEvenNumbers;
}

Console.Clear();
Console.Write("Ведите длинну массива: ");
int numberLength = Convert.ToInt32(Console.ReadLine());
int result = NewRandomArray(numberLength);

Console.WriteLine();
Console.Write($" The number of even elements in this array is: {result}");
Console.WriteLine();
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int NewRandomArray(int SizeArray)
{
    int[] array = new int[SizeArray];
    Random rand = new Random();
    int SummOfNonEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(10, 50); 
            Console.Write($" {array[i]}");
            if (i%2 != 0)
            {
                SummOfNonEvenNumbers += array[i];
            }
        }   
    return SummOfNonEvenNumbers;
}

Console.Clear();
Console.Write("Ведите длинну массива: ");
int numberLength = Convert.ToInt32(Console.ReadLine());
int result = NewRandomArray(numberLength);

Console.WriteLine();
Console.Write($" The sum of the elements standing in odd positions in this array is: {result}");
Console.WriteLine();
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
/*
double FindMinMax(double [] arrayD)
{
    int minPosition = 0;
    int maxPosition = 0;
    for (int i = 0; i < arrayD.Length; i++)
    {
        if (arrayD[minPosition] > arrayD[i]) 
            minPosition = i;
        else if (arrayD[maxPosition] < arrayD[i])
            maxPosition = i;    
    }
    return arrayD[maxPosition] - arrayD[minPosition];
}

double [] NewRandomArray(int SizeArray)
{ 
    double[] array = new double[SizeArray];
    Random rand = new Random();
    
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(rand.Next(1, 100) + rand.NextDouble()); 
            Console.Write($" {array[i]:f2}");
        }   
    return array;
}

Console.Clear();
Console.Write("Ведите длинну массива: ");
int numberLength = Convert.ToInt32(Console.ReadLine());
double [] arry = NewRandomArray(numberLength);

Console.WriteLine();
Console.Write($" The the difference between max and min elements in this array is: {FindMinMax(arry):f2}");
Console.WriteLine();
*/
