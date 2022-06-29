// Задача 50: Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();
Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[4, 4];
GetRandomArray(matrix);
PrintArray(matrix);
WriteLine();
GetNumberInArray(matrix);



int GetNumberInArray(int[,] matr)
{
int m=0, n=0;
bool f = false;
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (number == matr[i, j]) { m = i;n = j;f = true; };
    }
}
if (f)
    WriteLine($"Число найдено. Строка {m+1} Столбец {n+1}");
else
WriteLine("Число не найдено");
return number;
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

void GetRandomArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 20); 
        }
    }
}
