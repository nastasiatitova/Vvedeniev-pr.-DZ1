// 54  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = Promt("Введите количество строк массива");
int n = Promt("Введите количество столбцов массива");
Console.WriteLine();

Console.WriteLine("Первоначальный массив");
Console.WriteLine();

int[,] CreateOutputArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[,] array = CreateOutputArray(m, n);


int[,] ResultArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] >= array[i, k])
                {
                    int tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
    return array;
}

int[,] rezarray = ResultArray(array);

void OutputArray(int[,] rezarray)
{
    for (int i = 0; i < rezarray.GetLength(0); i++)
    {
        for (int j = 0; j < rezarray.GetLength(1); j++)
        {
            Console.Write(rezarray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Новый массив");
Console.WriteLine();
OutputArray(rezarray);
*/

// 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 

/*
int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = Promt("Введите количество строк массива");
int n = Promt("Введите количество столбцов массива");
Console.WriteLine();

int[,] CreateOutputArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[,] array = CreateOutputArray(m, n);

int[] SumArray(int[,] array)
{
    int count = 0;
    int[] sarray = new int[m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }
        sarray[count] = sum;
        count++;
    }
    return sarray;
}

int[] newarray = SumArray(array);

Console.WriteLine("Суммы элементов по строкам:");
Console.WriteLine(String.Join("\t", newarray));
Console.WriteLine();

void Min(int[] newarray)
{
    int str = 1;
    for (int i = 0; i < newarray.Length - 1; i++)
    {
        int min = newarray[0];
        if (newarray[i] < min)
        {
            min = newarray[i];
            str = i + 1;
        }
    }
    Console.WriteLine("Наименьшая сумма элементов в строке " + str);
}

Min(newarray);
Console.WriteLine();
*/

//58  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m1 = Promt("Введите количество строк массива");
int n1 = Promt("Введите количество столбцов массива");
Console.WriteLine();
int m2 = m1;
int n2 = n1;


Console.WriteLine("Первый массив");
Console.WriteLine();

int[,] CreateOutputArray(int m1, int n1)
{
    int[,] matrix1 = new int[m1, n1];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write(matrix1[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix1;
}

int[,] array1 = CreateOutputArray(m1, n1);

Console.WriteLine("Второй массив");
Console.WriteLine();

int[,] CreateOutputArray2(int m2, int n2)
{
    int[,] matrix2 = new int[m2, n2];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(1, 10);
            Console.Write(matrix2[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix2;
}

int[,] array2 = CreateOutputArray2(m2, n2);

int[,] MultiplyArray(int[,] array1, int[,] array2)
{
    int[,] marray = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {

        for (int j = 0; j < array1.GetLength(1); j++)
        {
            marray[i, j] = array1[i, j] * array2[i, j];
            Console.Write(marray[i, j] + "\t");
        }
Console.WriteLine();
    }
    return marray;
}

Console.WriteLine("Произведение элементов массива:");
Console.WriteLine();
MultiplyArray(array1, array2);
*/

// 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = Promt("Задайте параметр 1 массива");
int n = Promt("Задайте параметр 2 массива");
int c = Promt("Задайте параметр 3 массива");
Console.WriteLine();

int[,,] GenerateArray(int m, int n, int c)
{
    int[,,] array = new int[m, n, c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                int r = array[i, j, k];
                if (r == array[i, j, k])
                    array[i, j, k] = new Random().Next(10, 100);
            }

        }
    }
    return array;
}



Console.WriteLine("Трехмерный массив");
Console.WriteLine();
int[,,] garray = GenerateArray(m, n, c);

void PrintArray(int[,,] garray)
{
    for (int i = 0; i < garray.GetLength(0); i++)
    {
        for (int j = 0; j < garray.GetLength(1); j++)
        {
            for (int k = 0; k < garray.GetLength(2); k++)
            {
                Console.Write(garray[i, j, k] + "\t");

            }
            Console.WriteLine();
        }
    }
}

void PrintInd(int[,,] garray)
{
    for (int i = 0; i < garray.GetLength(0); i++)
    {
        for (int j = 0; j < garray.GetLength(1); j++)
        {
            for (int k = 0; k < garray.GetLength(2); k++)
            {
                Console.Write($"{garray[i, j, k]}({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine();
PrintArray(garray);
Console.WriteLine();
PrintInd(garray);
*/

//62 Напишите программу, которая заполнит спирально массив 4 на 4.

int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = Promt("Задайте количество строк массива");
int n = Promt("Задайте количество столбцов массива");

int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
            Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
