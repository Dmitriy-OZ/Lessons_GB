/*int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {11, 21, 31, 141, 15, 61, 17, 18, 19};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);


Console.WriteLine(result);
*/
// Home work №1// Home work №1
// Home work №1// Home work №1
// Home work №1// Home work №1
// Home work №1// Home work №1
//Задание 1//Задание 1//Задание 1//Задание 1//Задание 1//Задание 1//Задание 1
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
/*
Console.Write("Enter first number: ");
int numberF = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int numberS = Convert.ToInt32(Console.ReadLine());

if (numberF > numberS)
{
    Console.WriteLine($"Первое число {numberF} больше второго {numberS}");
}
else
{
    Console.WriteLine($"Первое число {numberF} меньше второго {numberS}");
}
*/



//Задание 2//Задание 2//Задание 2//Задание 2//Задание 2//Задание 2//Задание 2
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.
/*
Console.Write("Enter first number: ");
int numberF = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int numberS = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int numberT = Convert.ToInt32(Console.ReadLine());

int maxNumber = 0;
string pn = "";

if (numberF > numberS)
{
    maxNumber = numberF;
    pn = "первое";
}
else
{
    maxNumber = numberS;
    pn = "второе";
}
if (numberT > maxNumber)
{
    maxNumber = numberT;
    pn = "третье";
}

Console.WriteLine($"Из трех чисел {numberF}, {numberS}, {numberT} {pn} число самое большое {maxNumber}");
*/

//Задание 3//Задание 3//Задание 3//Задание 3//Задание 3//Задание 3//Задание 3
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ost = number % 2;

//Console.WriteLine($"Число {ost} четное!");

if (ost != 0)
{
    Console.WriteLine($"Число {number} не четное!");
}
else
{
    Console.WriteLine($"Число {number} четное!");
}
*/

//Задание 4//Задание 4//Задание 4//Задание 4//Задание 4//Задание 4//Задание 4
//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
/*
Console.Clear();
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int step = 2;

int num = 0;

while (num < number)
{
    Console.Write($"{num} ");
   //Console.Write(" ");
    num = num + step;
}
Console.Write(" \n");
*/

///* Напишите программу, которая принимает на вход
//число (N) и выдаёт таблицу квадратов чисел от 1 до N.*/

/*
void Sqwear(int num)
{
    int step = 1;
    while (num > step)
    {
        Console.WriteLine( step * step );
        step++;
    }
}

Console.Write("My number is: ");
int number = Convert.ToInt32(Console.ReadLine());

Sqwear(number);
*/



