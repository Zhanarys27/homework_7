﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5    7     -2    -0,2
// 1    -3,3     8    -9,9
// 8     7,8   -7,1     9
Console.Clear();

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().NextDouble()*10;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            
            Console.Write($"{Math.Round(array[i,j],1),3}    ");
        System.Console.WriteLine();
        }
}

System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rows, cols];
FillArray(array);
PrintArray(array);