/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/



//Home work 6
/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
Console.Clear();
Console.Write("How many numbers are we entering? ");
int Iter = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 0; i < Iter; i++)
{
    Console.Write($"Number №{i+1}: ");
    if (Convert.ToInt32(Console.ReadLine()) > 0)
    {
        result ++;
    }   
}
Console.Write($"In the entered numbers the number of positive is {result}");
Console.WriteLine();
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
int CheckingCoordinates(double b1, double k1, double b2, double k2)
{
    int temp = 0;//a-b;b-k
    if ((b1 * k2 - b2 * k1) == 0)
    {
        Console.Write("Lines are parallel");
        temp = 1;
    }
    return temp;//0 or 1
}

Console.Write("Entering k1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Entering b1: ");
var k1= Convert.ToDouble(Console.ReadLine());
Console.Write("Entering k2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Entering b2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

//Проверим что прямые не паралельны
int rte = CheckingCoordinates( b1,  k1,  b2,  k2);
if (rte == 0)
{
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"The lines intersect at the coordinate: х = {x}; у ={y}");

}
*/
