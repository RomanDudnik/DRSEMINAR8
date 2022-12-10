// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

/*
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int [,] New2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minValue, maxValue + 1);
    return createdArray;
}

void Show2dArray (int [,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] MaxToMinRows(int [,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array1.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(1)-1; k++)
                if (array1[i, k] < array1[i, k+1])
                {
                    int temp = array1[i, k + 1];
                    array1[i, k + 1] = array1[i, k];
                    array1[i, k] = temp;
                }
    return array1;
}

Console.WriteLine("Input count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newArray = New2dArray(m, n, min, max);
Show2dArray(newArray);
int [,] SortedRows = MaxToMinRows(newArray);
Show2dArray(SortedRows);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
/*
1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7
*/
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//наименьшей суммой элементов: 1 строка

/*
int [,] New2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minValue, maxValue + 1);
    return createdArray;
}

void Show2dArray (int [,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSumRowIndex(int [,] array1)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;

    for (int i = 0; i < array1.GetLength(1); i++)
    {
        minRow += array1[0, i];
    }
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++) 
            sumRow += array1[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;             
    }
    Console.WriteLine($"Row No. {minSumRow} with the smallest sum {minRow} in this array.");  
}

Console.WriteLine("Input count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

if (m != n)
{
    int [,] newArray = New2dArray(m, n, min, max);
    Show2dArray(newArray);
    MinSumRowIndex(newArray);   
}
else Console.WriteLine("Define a rectangular array!");
*/

// Задача 58(дополнительно): Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
/*
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


// Задача 60(дополнительно): ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
/*
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void Show2dArray (int [,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SpiralSquareArray (int [,] array)
{
    int i = 0, j = 0;
    int element = 1;
    int n = array.GetLength(0);
    for (int l = 0; l < n * n; l++)
    {
        int k = 0;
        do { array[i, j++] = element++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) 
            array[i++, j] = element++;
            for (k = 0; k < n - 1; k++) 
                array[i, j--] = element++;
                for (k = 0; k < n - 1; k++) 
                    array[i--, j] = element++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

Console.WriteLine("Input the number of rows/columns of the square array : ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;

int [,] squareArray = new int [n, m];

SpiralSquareArray(squareArray);
Show2dArray(squareArray);
