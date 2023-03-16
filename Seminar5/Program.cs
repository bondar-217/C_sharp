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

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int FindCountArray(int minNum, int maxNum, int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)

//     {
//         if (array[i] >= minNum && array[i] <= maxNum)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input MinNum:");
// int minNum = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Input MaxNum:");
// int maxNum = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array);
// Console.WriteLine(FindCountArray(minNum, maxNum, array));



// //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// //Напишите программу, которая покажет количество чётных чисел в массиве.
// //[345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// int FindCountPositiveNum()


// // egor arr[i] = Math.Round(rand.Next(start, end) + rand.NextDouble(), 4);

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
//     if (numbers[i] % 2 == 0)
//         count++;

// Console.WriteLine($"всего чисел {numbers.Length} , {count} - количество четных чисел");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100, 999 + 1);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write(" ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("");
//     Console.WriteLine();
// };


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);

// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i = i + 2)
//     sum = sum + numbers[i];

// Console.WriteLine($"всего чисел {numbers.Length} , сумма чисел на нечётных индексах = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(1, 10);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"всего чисел {numbers.Length}  Максимальное число = {max}, минимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
};