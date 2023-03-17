// 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] CreateOutputArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble()*20, 2);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int m = Promt("Введите количество строк массива");
int n = Promt("Введите количество столбцов массива");
CreateOutputArray(m,n);
*/

// 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateOutputArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,20);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int m = Promt("Введите количество строк массива");
int n = Promt("Введите количество столбцов массива");
Console.WriteLine();
int[,] matr = CreateOutputArray(m,n);

int s = Promt("Введите номер строки искоимого элемента");
int t = Promt("Введите номер столбца искоимого элемента");

void SearchValue(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        if  (s == i+1 && t == j+1)
          Console.WriteLine("В этой ячейке число " + matr[i,j]);
        }    
    }
}

Console.WriteLine();
SearchValue(matr);

if (s > m || t > n)
Console.WriteLine("Нет элемента с таким номером строки или столбца");
Console.WriteLine();
*/

// 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateOutputArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,20);
            Console.Write(matrix[i, j] + "\t");         
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int m = Promt("Введите количество строк массива");
int n = Promt("Введите количество столбцов массива");
Console.WriteLine();
int [,] matrix = CreateOutputArray(m,n);


void ArMean(int[,] matrix)
{
       
for (int j = 0; j < n; j++)
    {
        double sum=0;
        for (int i = 0; i < m; i++)
        {
        sum = sum + matrix[i,j];
        }
        Console.Write($"{ Math.Round((sum / m), 2)} ");
    }
    }

Console.Write("Среднее арифметическое столбцов : ");
ArMean(matrix);