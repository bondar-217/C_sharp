
// /*int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));
// */

// // int FindDigit(int num)
// // {
// //     int count = 1;
// //     while(num>10)
// //     {
// //         num = num / 10;
// //         count++;
// //     }
// //     return count;
// // }

// // Console.WriteLine ("Input number:");
// // int a = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine(FindDigit(a));


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine($"\nЗадача 27. Выдаёт сумму цифр в числе");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces(string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2(int series)
{

    if (series == '0' || series == '1' || series == '2'
    || series == '3' || series == '4' || series == '5' || series == '6'
    || series == '7' || series == '8' || series == '9' || series == ','
    || series == '-')
    {
    }
    else
    {
        Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

    }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew)
{

    int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            СheckNumber2(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);