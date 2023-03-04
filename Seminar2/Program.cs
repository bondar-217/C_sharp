/*Console.Write("Input your number: ");
int a = Convert.ToInt32(Console.ReadLine());

bool Kratnost(int num)
{
    if (num % 7 == 0 && num % 23 == 0) return true;
    else return false;
}

bool result = Kratnost(a);
Console.WriteLine(result);
*/

/*
Console.Write("Input your number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number 2: ");
int b = Convert.ToInt32(Console.ReadLine());


bool Kvadrat(int num1, int num2)
{
    if ((num2 == num1 * num1) || (num1 == num2 * num2)) return true;
    else return false;
}

bool result = Kvadrat(a, b);
Console.WriteLine(result);
*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int SecondValue(int num)
{
    int second = num % 100 / 10;
    return second;

}
int randomnum = new Random().Next(100, 1000);
Console.WriteLine(randomnum);
Console.WriteLine(SecondValue(randomnum));
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int LastValue(int num)
{

    //int last = (num % 10);
    int last = 0;
    if (last < 100) Console.Write("Нет третьего числа: ");
    else return last = (num % 10);
    //if (last < 100) Console.Write("Нет третьего числа: ");
}


Console.Write("Input your number : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number);
Console.WriteLine(LastValue(number));