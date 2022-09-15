/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

//Home work 5

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*//*
const int SIZE = 20;
int quantity1 = 0;
var nums = Enumerable.Range(100, SIZE).ToList();
int[] result = new int[SIZE];
Random rand = new Random();
for (int i = 0; i < SIZE; i++)
{
    int pos = rand.Next(0, nums.Count);
    result[i] = nums[pos];
    nums.RemoveAt(pos);
}
foreach (var i in result)
{
    Console.Write(" " + i);
    if (i % 2 == 0)
    {
    quantity1 += 1;    
    }
    
}
Console.WriteLine();
Console.Write(" Четных элементов: " + Convert.ToString(quantity1));
*//*
void NewRandomArray(int SizeArray)
{
    int[] array = new int[SizeArray];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(); // [0 - 2^31)
}
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/