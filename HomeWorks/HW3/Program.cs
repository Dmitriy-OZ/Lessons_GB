/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
*/
/*
void raschet(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между двумя точками в 3D равно {distance}");
}

Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

raschet(x1, x2, y1, y2, z1, z2);
*/
/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Kub(int number)
{
   for (int i = 1; i <= number; i++)
   {
        Console.WriteLine($" {i*i*i}");
   }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Kub(number);
*/

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
void IsThisPaliandrom(string number)
{
    bool pal = false;
    for (int i = 0; i < number.Length / 2; ++i)
        if (number[i] != number[number.Length - 1 - i])
            pal = false;
        else
            pal = true;
    if (pal)
    {
        Console.WriteLine($" Число {number} является палиндромом!");
    }
    else
    {
        Console.WriteLine($" Число {number} палиндромом не является!");
    }
}

Console.Clear();
Console.Write("Введите число: ");
string  number = Convert.ToString(Console.ReadLine());

IsThisPaliandrom(number);
*/