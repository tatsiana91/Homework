﻿Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


void FilArray(double [,]array)
{
  for (int i =0;i<array.GetLength(0);i++)
        for (int j =0;j<array.GetLength(1);j++)
            array[i,j] = new Random().NextDouble()*100;
}

void PrintArray(double[,] array)
{
    for (int i =0;i<array.GetLength(0);i++)
        {
        for (int j =0;j<array.GetLength(1);j++)
        Console.WriteLine(Math.Round( array[i,j],2  ));
        System.Console.WriteLine();
        }
}


System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rows,cols];
FilArray(array);
PrintArray(array);

Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Console.Clear();
System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 50);
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}    ");
        System.Console.WriteLine();
    }
}
void AvarageCols(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        System.Console.WriteLine($"среднее арифметическое {i} столбца ={sum/array.GetLength(1)}" );
    }
}
    FillArray(array);
    PrintArray(array);
    AvarageCols(array);

Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
 
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,16));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите число в строке");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число в столбце");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>rows && b>cols)
 Console.WriteLine("такого числа нет");
