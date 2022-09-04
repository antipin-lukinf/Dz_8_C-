/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

class Program
{
    static void Main()
    {
        Console.Write("Введите кол-во строк матрицы A: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите кол-во столбцов матрицы A: ");
        int n = int.Parse(Console.ReadLine());
        int[,] array1 = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("A[{0},{1}] = ", i, j );
                array1[i,j] = int.Parse(Console.ReadLine());
            }  
        }

        Console.Write("Введите кол-во строк матрицы B: ");
        int m1 = int.Parse(Console.ReadLine());
        Console.Write("Введите кол-во столбцов матрицы B: ");
        int n1 = int.Parse(Console.ReadLine());
        int[,] array2 = new int[m1, n1];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write("A[{0},{1}] = ", i, j );
                array2[i,j] = int.Parse(Console.ReadLine());
            }  
    }
    Console.Clear();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("{0} ", array1[i, j]);
        }
        Console.WriteLine(" ");
        
    }
    Console.WriteLine(" ");
    for (int i = 0; i < m; i++)
    {
         for (int j = 0; j < n; j++)
        {
            Console.Write("{0} ", array2[i, j]);
        }
        Console.WriteLine(" ");
        
    }
    Console.WriteLine(" ");
    int[,] work = new int[array1.GetLength(0), array2.GetLength(0)];

    for(int i = 0; i < array1.GetLength(0); ++i)
    {
        for(int j = 0; j < array2.GetLength(0); ++j)
        {
            for(int k = 0; k < array2.GetLength(1); ++k)
            {
                work[i, k] += array1[i, j] * array2[j, k];
            }
        }
    }
    for (int i = 0; i < array1.GetLength(0); ++i)
    {
        for (int j = 0; j < array2.GetLength(1); ++j)
        {
            Console.Write(work[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    }
}