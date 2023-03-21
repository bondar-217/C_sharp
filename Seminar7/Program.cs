// // //Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // double[,] Create2DRandomArray(double rows, double columns, double minValue, double maxValue)
// // {
// //     double[,] myArray = new double[rows, columns]; //выделили память под массив
// //     for (double i = 0; i < rows; i++)
// //     {
// //         for (double j = 0; j < columns; i++) ;
// //         {
// //             myArray[i, j] = new Random().Next(minValue, maxValue + 1); //заполняем массив методом рандом
// //         }
// //     }
// //     return myArray;
// // }

// // void Show2DArray(double[,] array) //метод для вывода 2мерного массива
// // {
// //     for (double i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (double j = 0; j < array.GetLength(1); i++) ;
// //         {
// //             Console.Write(array[i, j] + "  ");
// //         }
// //         Console.WriteLine();
// //     }
// //     Console.WriteLine();
// // }

// // Console.Write("Введите количество строк ");
// // double rows = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите количество столбцов ");
// // double columns = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите минимальное значение ");
// // double minValue = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите максимальное значение ");
// // double maxValue = Convert.ToInt32(Console.ReadLine());
// // Show2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));



// //Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// // Выведите полученный массив на экран

// // double[,] Create2DArray(double rows, double columns)
// // {
// //     double[,] myArray = new double[rows, columns];
// //     for (double i = 0; i < rows; i++)
// //     {
// //         for (double j = 0; j < columns; j++)
// //         {
// //             myArray[i, j] = i + j;
// //         }
// //     }
// //     return myArray;
// // }
// // // 1 2 3
// // // 4 5 6
// // // 7 8 9

// // void Show2DArray(double[,] array)
// // {
// //     for (double i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (double j = 0; j < array.GetLength(1); j++)
// //         {
// //             Console.Write(array[i, j] + " ");
// //         }
// //         Console.WriteLine();
// //     }
// //     Console.WriteLine();
// // }

// // Console.Write("Введите количество строк ");
// // double rows = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите количество столбцов ");
// // double columns = Convert.ToInt32(Console.ReadLine());


// // Show2DArray(Create2DArray(rows, columns));




// //Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// //Например, изначально массив выглядел вот так:

// //1 4 7 2
// //5 9 2 3
// //8 4 2 4
// //Новый массив будет выглядеть вот так:

// //1 4 7 2
// //5 **81  ** 2 **9**
// //8 4 2 4

// // double[,] EvenElementsArray(double[,] array)
// // {
// //     for (double i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (double j = 0; j < array.GetLength(1); j++)
// //         {
// //             if (i % 2 == 0 && j % 2 == 0)
// //                 array[i, j] = Math.Pow(array[i, j], 2);
// //         }
// //     }
// //     return Array;
// // }
// // Console.WriteLine();
// // myArray = EvenElementsArray(myArray);
// // Show2DArray(myArray);





// //Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// //Например, задан массив:

// //1 4 7 2                      Главная диагональ это когда i и j совпадают
// //5 9 2 3
// //8 4 2 4

// //Сумма элементов главной диагонали: 1+9+2 = 12

// // double SumDublicate(double[,] array)
// // {
// //     double sum = 0;
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             if (i == j)
// //                 sum += array[i, j];
// //         }
// //     }
// //     return sum;
// // }

// // Console.WriteLine($"Sum = {SumDublicate(myArray)}");




// double[,] Create2DRandomArray(double rows, double columns, double minValue, double maxValue)
// {
//     double[,] myArray = new double[rows, columns]; //выделили память под массив
//     for (double i = 0; i < rows; i++)
//     {
//         for (double j = 0; j < columns; i++) ;
//         {
//             myArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//         return myArray;
//     }
// }

// void Show2DArray(double[,] array) //метод для вывода 2мерного массива
// {
//     for (double i = 0; i < array.GetLength(0); i++)
//     {
//         for (double j = 0; j < array.GetLength(1); i++) ;
//         {
//             Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Create2DRandomArray(int m, int n, double minValue, double maxValue)
{
    double[,] myArray = new double[m, n]; //выделили память под массив
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            myArray[i, j] = random.NextDouble() * (maxValue - minValue) + minValue; //заполняем массив случайными вещественными числами
        }
    }
    return myArray;
}

void Show2DArray(double[,] array) //метод для вывода 2мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
double minValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
double maxValue = Convert.ToDouble(Console.ReadLine());
Show2DArray(Create2DRandomArray(m, n, minValue, maxValue));


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] myArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }; //задаем двумерный массив

// Console.Write("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int column = Convert.ToInt32(Console.ReadLine());

// if (row >= 0 && row < myArray.GetLength(0) && column >= 0 && column < myArray.GetLength(1)) //проверяем, что введенные позиции не выходят за пределы массива
// {
//     Console.WriteLine("Значение элемента: " + myArray[row, column]);
// }
// else
// {
//     Console.WriteLine("Указанный элемент отсутствует в массиве.");
// }



double[,] myArray = Create2DRandomArray(m, n, minValue, maxValue); //
Show2DArray(myArray);

for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += myArray[i, j];
    }
    double average = sum / m;
    Console.WriteLine("Среднее арифметическое элементов столбца " + (j + 1) + ": " + average);
}
