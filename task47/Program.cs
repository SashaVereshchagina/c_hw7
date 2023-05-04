﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

float [,] table = new float [m,n];
FillTable(table);
PrintTable(table);

void FillTable (float [,] table)

{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table [i,j] = new Random().Next(0,100);
        }
        
    }
}

void PrintTable (float [,] table)
{
    for (int rows = 0; rows < table.GetLength(0); rows++)
    {
        for (int columns = 0; columns < table.GetLength(1); columns++)
        {
            Console.Write($"{table[rows, columns]} ");
        }
    Console.WriteLine();    
    }
}



