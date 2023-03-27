// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] SortArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);

// myArray = SortArr(myArray);

// Show2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] SumRows(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Array is not rectangular");
//         return null;
//     }
//     else
//     {
//         int[] arraySumRows = new int[array.GetLength(0)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 arraySumRows[i] = arraySumRows[i] + array[i, j];
//             }
//         }
//         return arraySumRows;
//     }
// }

// void FindRowMin(int[] array)
// {
//     int minSumRow = array[0];
//     int minRow = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < minSumRow)
//         {
//             minSumRow = array[i];
//             minRow = i;
//         }
//     }
//     Console.WriteLine($"Число строк с мин. элементами: {minRow + 1}");
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное чисор: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);
// int[] arraySumRows = SumRows(myArray);
// FindRowMin(arraySumRows);


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


// int[,] First_Matrix(int rows1, int columns1)
// {
//     int[,] firstMatrix = new int[rows1, columns1];
//     for (int i = 0; i < rows1; i++)
//     {
//         for (int j = 0; j < columns1; j++)
//         {
//             firstMatrix[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return firstMatrix;
// }

// int[,] Second_Matrix(int rows2, int columns2)
// {
//     int[,] secondMatrix = new int[rows2, columns2];
//     for (int i = 0; i < rows2; i++)
//     {
//         for (int j = 0; j < columns2; j++)
//         {
//             secondMatrix[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return secondMatrix;
// }

// int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
//     if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
//     {
//         Console.WriteLine("Невозможно произвести умножение");
//     }
//     int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//     for (int i = 0; i < firstMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondMatrix.GetLength(1); j++)
//         {
//             resultMatrix[i, j] = 0;
//             for (int k = 0; k < firstMatrix.GetLength(1); k++)
//             {
//                 resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
//             }
//         }
//     }
//     return resultMatrix;
// }

// void ShowMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк в 1 матрице: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов в 1 матрице: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("ВВедите количество строк во 2 матрице: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов во 2 матрице: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());

// int[,] firstMatrix = First_Matrix(rows1, columns1);
// Console.WriteLine("Первая матрица: ");
// ShowMatrix(firstMatrix);

// int[,] secondMatrix = Second_Matrix(rows2, columns2);
// Console.WriteLine("Вторая матрица: ");
// ShowMatrix(secondMatrix);

// int[,] multiplicationMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
// Console.WriteLine("Результ: ");
// ShowMatrix(multiplicationMatrix);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.


// int[,,] Create3DRandomArray(int x, int y, int z, int minValue, int maxValue)
// {
//     int[,,] myArray = new int[x, y, z];
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 myArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return myArray;
// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите  x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите  y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите  z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(x, y, z, minValue, maxValue);

// Show3DArray(myArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] MakeArraySpiral(int rowP, int colP, int count, int[,] array)
{
    for (int j = 0; j < colP; j++)
    {
        array[0, j] = count;
        count++;
    }
    for (int i = 1; i < rowP; i++)
    {
        array[i, colP - 1] = count;
        count++;
    }
    for (int j = colP - 2; j >= 0; j--)
    {
        array[rowP - 1, j] = count;
        count++;
    }
    for (int i = rowP - 2; i > 0; i--)
    {
        array[i, 0] = count;
        count++;
    }
    int row = 1;
    int col = 1;

    while (count < rowP * colP)
    {
        while (array[row, col + 1] == 0)
        {
            array[row, col] = count;
            count++;
            col++;
        }

        while (array[row + 1, col] == 0)
        {
            array[row, col] = count;
            count++;
            row++;
        }

        while (array[row, col - 1] == 0)
        {
            array[row, col] = count;
            count++;
            col--;
        }

        while (array[row - 1, col] == 0)
        {
            array[row, col] = count;
            count++;
            row--;
        }
    }

    for (int i = 0; i < rowP; i++)
    {
        for (int j = 0; j < colP; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = count;
            }
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($" 0{array[i, j]}");
            else Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int rowP = 4;
int colP = 4;
int count = 1;

int[,] array = new int[rowP, colP];

array = MakeArraySpiral(rowP, colP, count, array);

Show2DArray(array);