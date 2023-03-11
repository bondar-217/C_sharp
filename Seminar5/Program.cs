//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FindSum(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) sumPos += array[i];
        else sumNeg += array[i];
    }

    Console.WriteLine($"Sum of positive digits is -> {sumPos}, Sum of negative digits is -> {sumNeg}");
}


Console.WriteLine("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
FindSum(myArray);
*/

/*

int[] ChangeElementsOfArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);
    }
    return array;
}

Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray (size, minValue, maxValue);
ShowArray(myArray);
myArray = ChangeElementsOfArray (myArray);
ShowArray(myArray);
*/



//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool FindNum(int num, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            // Console.WriteLine("Данное число есть");
            return true;

        }

    }
    //{
    // Console.WriteLine("Данного числа нет");
    return false;
    //}
}
Console.WriteLine("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input num:");
int num = Convert.ToInt32(Console.ReadLine());


int[] array = CreateRandomArray(size, minValue, maxValue);
ShowArray(array);
Console.WriteLine(FindNum(num, array));
*/

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindCountArray(int minNum, int maxNum, int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] >= minNum && array[i] <= maxNum)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input MinNum:");
int minNum = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input MaxNum:");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, minValue, maxValue);
ShowArray(array);
Console.WriteLine(FindCountArray(minNum, maxNum, array));
