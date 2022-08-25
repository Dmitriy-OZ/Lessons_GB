///* Напишите программу, которая принимает на вход
//число (N) и выдаёт таблицу квадратов чисел от 1 до N.*/


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
