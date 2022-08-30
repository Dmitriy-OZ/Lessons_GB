/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Kub(int number, int step)
{
    while (step <= number)
    {
        Console.Write($" {step*step*step} ");
        Console.Write(" ");
        step++;
    }

}

Console.Clear();
Console.Write("Vvedi chislo: ");
int number = Convert.ToInt32(Console.ReadLine());
int step = 1;
Kub(number, step);

*/
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
void IsThisPoliandr(int number)
{
    bool result = false;

    //проверка на полиандер...
    string numST = number.ToString();
    string[] arrNumber = new string[numST.Length];

    int schet = 0;
    while (schet < numST.Length)
    {
        Console.Write($" {numST[schet]}");
        Console.Write(" ");
        schet++;
    }
    Console.WriteLine(" ");
    Console.Write($" It's poliander  - {result}");
}

Console.Clear();
Console.Write("Vvedi chislo: ");
int number = Convert.ToInt32(Console.ReadLine());

IsThisPoliandr(number);