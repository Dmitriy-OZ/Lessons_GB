// Home work 2
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
//              123546           3
int FindNum(int number, int razryd)
{
    string numST = number.ToString();

    char[] array = new char[numST.Length];
    for (int i = 0; i < numST.Length; i++)
    {
        array[i] = numST[i];
        //Console.WriteLine($" i = {i} - {array[i]}");
    }

    return Convert.ToInt32(Convert.ToString(array[razryd-1]));
}

Console.Clear();
Console.Write("Ведите число для разбора: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите номер разряда: ");
int razryd = Convert.ToInt32(Console.ReadLine());

//проверка что в числе разрядов больше чем запрашивается
string numST1 = number.ToString();

if (numST1.Length >= razryd)
{
   Console.WriteLine($" {FindNum(number, razryd)}");
}
else
{
   Console.WriteLine($" В этом числе нет столько цифр");
}

//Console.WriteLine(Convert.ToInt32(Convert.ToString(c)));
*/
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

+ *********Решение**************

*//*
int FindNum(int number, int razryd)
{
    string numST = number.ToString();

    char[] array = new char[numST.Length];
    for (int i = 0; i < numST.Length; i++)
    {
        array[i] = numST[i];
        //Console.WriteLine($" i = {i} - {array[i]}");
    }

    return Convert.ToInt32(Convert.ToString(array[razryd-1]));
}

Console.Clear();
Console.Write("Ведите число для разбора: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите номер разряда: ");
int razryd = Convert.ToInt32(Console.ReadLine());

//проверка что в числе разрядов больше чем запрашивается
string numST1 = number.ToString();

if (numST1.Length >= razryd)
{
   Console.WriteLine($" {FindNum(number, razryd)}");
}
else
{
   Console.WriteLine($" В числе {number} нет цифры под разрядом {razryd}");
}

//Console.WriteLine(Convert.ToInt32(Convert.ToString(c)));
*/
/*

- *********Решение**************

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
//             0 1 2 3 4 5 6
string[] array = { "1", "2", "3", "4", "5", "6", "7" };
Console.Write("Ведите день недели(от 1 до 7): ");
string number = Convert.ToString(Console.ReadLine());

int intnum = Convert.ToInt32(number);
if (intnum > 1 & intnum < 7)
{
    if (number == array[5] | number == array[6])
    {
        Console.WriteLine($" Сегодня выходной!!!");
    }
    else
    {
        //Console.WriteLine($"  {array.Length}");
        //Console.WriteLine($"  {number}");
        if (number == array[4])
        {
            Console.WriteLine($" Уже завтра выходной!!!");
        }
        else
        {
            Console.WriteLine($" Придется поработать еще {array.Length - 2 - Convert.ToInt32(number)} денька");
        }
    }
}
else
{
   Console.WriteLine($" Введено не корректное число {number}. Нужно ввести число от 1 до 7...");
}
*/
//Hi1