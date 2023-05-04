// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] table = new int [4,6];
FillTable(table);
PrintTable(table);

for (int i = 0; i < table.GetLength(1); i++)
{
    float sum = 0;
    float result = 0;
    for (int j = 0; j < table.GetLength(0); j++)
    {
        sum = sum + table[j,i];
    }
    result = sum / table.GetLength(0);
    Console.WriteLine("Среднее арифметическое элементов столбца " + i + " = " + result);
}

void FillTable (int [,] table)

{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table [i,j] = new Random().Next(0,100);
        }
        
    }
}

void PrintTable (int [,] table)
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
