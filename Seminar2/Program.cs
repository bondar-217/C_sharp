
/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondValue(int num)
{
    int second = num % 100 / 10;
    return second;

}
int randomnum = new Random().Next(100, 1000);
Console.WriteLine(randomnum);
Console.WriteLine(SecondValue(randomnum));
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int LastValue(int number)
{
    int result = -0;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;

}
Console.Write("Input your number : ");
int number = Convert.ToInt32(Console.ReadLine());

if (LastValue(number) == -0) Console.WriteLine("третьей цифры нет");
else Console.WriteLine(number);
Console.WriteLine(LastValue(number));


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Введи день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void Weekendornot(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("выходной)");
    }
    else if (day > 7 | day < 0) Console.WriteLine("ошибка");
    else Console.WriteLine("(арбайтен)");

}
Weekendornot(day);
*/