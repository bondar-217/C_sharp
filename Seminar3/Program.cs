// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
/*
Console.Write("Введите число: ");
string number = Console.ReadLine();

void Palindrom(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"  {number} - палиндром.");
    }
    else Console.WriteLine($" {number} - не палиндром.");
}

if (number!.Length == 5)
{
    Palindrom(number);
}
else Console.WriteLine($"Некорректное число");
*/

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
int x1 = FindDistance("x", "A");
int y1 = FindDistance("y", "A");
int z1 = FindDistance("z", "A");
int x2 = FindDistance("x", "B");
int y2 = FindDistance("y", "B");
int z2 = FindDistance("z", "B");

int FindDistance(string coordinate, string point)
{
    Console.Write($"Введи координату {coordinate} точки {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Result(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

double segmentLength = Math.Round(Result(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина {segmentLength}");
*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
    int counter = 0;
    int length = cube.Length;
    while (counter < length)
    {
        counter = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArray(int[] num)
{
    int count = num.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(num[index] + " ");
        index++;
    }
}

int[] array = cube + 1;
Cube(array);
PrintArray(array);