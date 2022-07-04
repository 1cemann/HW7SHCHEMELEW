// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
using System;
using static System.Console;


Clear();
int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
WriteLine();
//WriteLine($"{GetAverageArray(matrix)}");
GetAverageArray(matrix);

void GetAverageArray(int[,] matr)
{
    int sum=0;
    int average=0;
    for(int i=0;i<matr.GetLength(0);i++)
    {
        for(int j=0;j<matr.GetLength(1);j++)
        {
            sum+=matr[i,j];
            average=sum/matr.Length; 
        }
        
        Write($"{average} ");
    }
    
    
}














void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Write($"{matr[i, j]} ");
        }
        WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}