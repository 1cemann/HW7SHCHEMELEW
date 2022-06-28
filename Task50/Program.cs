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
int find=int.Parse(ReadLine());


int[,] matrix = new int[4, 4];
GetRandomArray(matrix);
PrintArray(matrix);



int GetNumberInArray(int[,] matr)
{
    if(position[0]<=m&&position[1]<=n&&position[0]>=0&&position[1]>=0)
    {
        int result = array[position[0]-1, position[1]-1];
        Console.Write($"Значение элемента: {result}");
    }
    else Console.Write($"такого элемента в массиве нет."); 
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
            matr[i, j] = new Random().Next(1, 100); 
        }
    }
}
