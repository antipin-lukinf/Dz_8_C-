/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System;

Console.WriteLine("Введите количество строк массива :");
int m = int.Parse(Console.ReadLine());


int n = m + 1;
int minSummRow = 0;
int str = 0;

int[,] a = new int[m, n];
Random random = new Random();

void FillArray(string args)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(0, 100);
            Console.Write($"[{String.Join(",", a[i, j])}]");
        }
        Console.WriteLine();
    }

}
FillArray(Convert.ToString(1));


int[] summ = new int[m];
minSummRow = 1000;
for (int i = 0; i < m; i++)
{
    
    
    for (int j = 0; j < n; j++)
    {
        summ[i] += a[i, j];
        
        
    }
    
    Console.WriteLine();
    if (summ[i] < minSummRow)
    {
        minSummRow = summ[i];
        Console.WriteLine($"номер строки с минимальной суммой эл-тов: {i+1}");  
        
    }
    else minSummRow = minSummRow;

}
Console.WriteLine(minSummRow);
