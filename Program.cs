// Урок 7. Двумерные массивы. Домашняя работа. 
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.WriteLine(" ");
Console.WriteLine("*** Давайте создадим массив из вещественных чисел ***");
Console.WriteLine(" ");

// Ввод данных
//int m=5, n=10, min=-100, max=100;
Console.Write("* Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("* Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("* Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("* Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

// Решение без использование метода
double [,] array = new double [m, n];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        array [i, j] = new Random().Next(min,max);
        array [i,j] = array [i,j]/10;
        Console.Write(" "+array[i, j]);
    }
    Console.WriteLine(" ");
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 1,2 -> 2

Console.WriteLine(" ");
Console.WriteLine("*** Давайте найдем число в массиве по позиции X и Y ***");

// Метод содания двумерного массива
int[,] CreateRandom2dArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(1, 100);

    return (array);
}
// Метод показа двумерного массива
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { //array.GetLength(0) - значит берем длинну по строкам
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    }
    
}

// Ввод данных
int rows = new Random().Next(1, 5);
int cols = new Random().Next(5, 10);

int[,] array = CreateRandom2dArray(rows, cols);
Show2dArray(array);
Console.WriteLine(" ");

Console.Write("* Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("* Введите номер столбика: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
if (x>(rows+1) || x<=0) Console.Write($" * Такого числа нет в массиве");
else if (y>(cols+1) || y<=0) Console.Write($" * Такого числа нет в массиве");
else Console.Write($" * Искомамое число {array[x-1, y-1]}");

*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine(" ");
Console.WriteLine("*** Давайте найдем среднее арифметическое столбцов массива ***");
Console.WriteLine(" ");

// Метод содания двумерного массива
int[,] CreateRandom2dArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(1, 10);

    return (array);
}

// Метод показа двумерного массива
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { //array.GetLength(0) - значит берем длинну по строкам
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  |  ");
        }
    }
}

// Метод рассчета среднего арифметического
void ArithmeticMean(int[,] array, int rows, int cols)
{
    for (int i = 0; i < cols; i++){
        double sumCols =0;
        double arifmeticCols=0;
        for (int j = 0; j < rows; j++)
        {
            sumCols = sumCols + array [j,i];
        }
        arifmeticCols=sumCols/2;
        Console.Write(arifmeticCols +" | ");
    }
}

// Ввод данных

int rows = new Random().Next(1, 5);
int cols = new Random().Next(1, 5);


int[,] array = CreateRandom2dArray(rows, cols);
Show2dArray(array);
Console.WriteLine();
ArithmeticMean (array, rows, cols);