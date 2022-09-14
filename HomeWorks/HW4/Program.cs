/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
/*
//Задание 1
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
int VStepen(int number, int stepen)
{
    int result = 1;
    for (int i = 1; i <= stepen; i++)
    {
        result *= number;
    }
return result;
}

Console.Clear();
Console.Write("Введите число для возведения в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень возвести число: ");
int stepen = Convert.ToInt32(Console.ReadLine());
 

Console.WriteLine($"{number} в степени {stepen} равно {VStepen(number, stepen)}");
*/

/*
Задание 2
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
void SumNumber(string number)
{
    //Console.WriteLine($" {number.Length}");
    int result = 0;
    char[] array = new char[number.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number[i];
       //Console.WriteLine($" {number[i]}");
       result += Convert.ToInt32(Convert.ToString(array[i]));
    }

    Console.WriteLine($" {result}");
}

Console.Clear();
Console.Write("Ведите число для для сложения его цифр: ");
string number = Console.ReadLine();

SumNumber(number);
*/
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*


void PrintingArryMy(string num)
{
    //Console.WriteLine($" {num}");
    int[] array = new int[Convert.ToInt32(num)];
    var r = new Random();
    string razdelitel = "";
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = r.Next(10, 50);
        if (i == array.Length-1)
        {
            razdelitel = "";
        }
        else
        {
            razdelitel = ",";
        }
        Console.Write($" {Convert.ToString(array[i])} {razdelitel}");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Ведите длинну массива: ");
string numberLength1 = Console.ReadLine();

PrintingArryMy(numberLength1);
*/