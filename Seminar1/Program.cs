//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int A = -9;
int B = -3;

if (A > B)
{
    Console.WriteLine("Max number A, Min number B");
}
else
{
    Console.WriteLine("Max number B, Min number A ");
}
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max= ");
Console.WriteLine(max);
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число НЕчетное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int chet = 0; //количество четных чисел
int index = 1;
while (index <= a)
{
    if (index % 2 == 0)
    { chet++; index++; }
    else { index++; }

}
Console.Write("Количество четных чисел от 1 до введенного числа ");
Console.WriteLine(chet);







// void ShowRange(int quat)
// {
//     if(quat == 1) Console.WriteLine($"X range is (0, +inf), Y range is (0, +inf)");
//     if(quat == 2) Console.WriteLine($"X range is (0, -inf), Y range is (0, +inf)");
//     if(quat == 3) Console.WriteLine($"X range is (0, -inf), Y range is (0, -inf)");
//     if(quat == 4) Console.WriteLine($"X range is (0, +inf), Y range is (0, -inf)");
// }
// Console.WriteLine("Input the quater:");
// int quad = Convert.ToInt32(Console.ReadLine());
// if(quad < 1 | quad > 4)
// {
//     Console.WriteLine("You input wrong number");
// }
// else
// {
//     ShowRange(quad);
// }



double Power(double digit)
{
    return Math.Pow(digit, 2);
}
Console.WriteLine("Input the number N:");
double N = Convert.ToDouble(Console.ReadLine());
double i = 1;
while (i <= N)
{
    Console.Write($"{Power(i)} ");
    i++;
}



double FindDistance(double x1, double y1, double x2, double y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
}

Console.WriteLine("Input coordinate X of A point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y of A point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate X of B point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate Y of B point: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = FindDistance(x1, y1, x2, y2);
Console.WriteLine($"Distance between A and B is {distance}");