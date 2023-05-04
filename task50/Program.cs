// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// ?? Тут подразумевается, что пользователь знает, что позиции с нуля начинаются??

Console.WriteLine("Введите строку элемента: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите столбец элемента: ");
int n = int.Parse(Console.ReadLine());

float [,] table = new float [4,6];
FillTable(table);
PrintTable(table);

if (m<4 & n<6) Console.WriteLine("Элемент массива: " + table[m,n]);
else Console.WriteLine("Элемента с такой позицией нет");


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
