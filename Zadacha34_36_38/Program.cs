// 34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
/*
int size = new Random().Next(5, 20);

int[] GetArray()
{
int [] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
}
return array;
}

int[] newarray = GetArray();
Console.WriteLine(String.Join(" ",newarray));

int CountEven()
{
    int count = 0;
 for (int i = 0; i < size ; i++)
 {
    if (newarray[i] %2 ==0)
    count ++;
 }
return count;
}

int even = CountEven();
Console.Write("Количество чётных чисел - ");
Console.WriteLine(String.Join(" ", CountEven()));
*/

// 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int Prompt(string message)
{
Console.WriteLine(message);
string ReadInput = Console.ReadLine();
int result = int.Parse(ReadInput);
return result;
}

int length = Prompt("Введите число элементов массива");
int min = Prompt("Начальное значение для вывода рандома");
int max = Prompt("Конечное значение для вывода рандома");

int[] GeneratArray(int length, int minValue, int maxValue)
{
int[] array = new int[length];
Random random = new Random();
for (int i = 0; i < length; i++)
{
    array[i] = random.Next(minValue, maxValue +1);
}
return array;
}

int[] newarray = GeneratArray(length, min, max);
Console.WriteLine(String.Join(" ", newarray));

int SumOdd()
{
int sum = 0;
    for (int i = 1; i < length; i= i+2)
    sum = sum + newarray[i];
return sum;
}

int sumodd = SumOdd();
Console.WriteLine(String.Join(" ", sumodd));*/

//38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// вариант 1

int Prompt()
{
Console.WriteLine("Введите количество элементов массива");
return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

double [] CreatArray()
{
double[] array = new double [size];
for (int i = 0; i < size; i++)
{
   array[i] = Math.Round(new Random().Next(0, 20) + new Random().NextDouble(), 3);
}
return array;
}
double[] newarray = CreatArray();

Console.WriteLine();

Console.WriteLine(String.Join(" ", newarray));

Console.WriteLine();

double MaxI()
{
double max = 0;
for (int i = 0; i < size; i++)
{
    if (newarray[i] > max)
    max = newarray[i];
}
return max;
}

double maxim = MaxI();
Console.WriteLine("Максимальное число " + maxim);

double MinI()
{
double min = newarray[0];
for (int i = 0; i < size; i++)
{
    if (newarray[i] < min)
    min = newarray[i];
}
return min;
}

double minim = MinI();
Console.WriteLine("Минимальное число " + minim);
Console.WriteLine();

double difference = Math.Round((maxim - minim), 3);

Console.WriteLine("Разница между максимальным и минимальным числами массива равна " +  difference);
Console.WriteLine();

// !!!!!!!!!! 2 вариант..... работает не правильно !!!!! не пойму почему
/*
int Prompt(string message)
{
Console.WriteLine(message);
string ReadInput = Console.ReadLine();
int result = int.Parse(ReadInput);
return result;
}

int length = Prompt("Введите число элементов массива");
int min = Prompt("Начальное значение для вывода рандома");
int max = Prompt("Конечное значение для вывода рандома");

Console.WriteLine();

double[] GeneratArray(int length, int minValue, int maxValue)
{
double[] array = new double[length];
Random random = new Random();
for (int i = 0; i < length; i++)
{
    array[i] = Math.Round(random.Next(minValue, maxValue +1) + new Random().NextDouble(), 3);
}
return array;
}

double [] newarray = GeneratArray(length, min, max);
Console.WriteLine(String.Join(" ", GeneratArray(length, min, max)));

Console.WriteLine();

double MaxI()
{
double max = newarray[0];
for (int i = 0; i < newarray.Length; i++)
{
    if (newarray[i] > max)
    max = newarray[i];
}
return max;
}
double maxim = MaxI();

Console.WriteLine(String.Join("", maxim));

double MinI()
{
double min = newarray[0];
for (int i = 0; i < length; i++)
{
    if (newarray[i] < min)
    min = newarray[i];
}
return min;
}

double minim = MinI();
Console.WriteLine(String.Join(" ", MinI()));

double difference = Math.Round((maxim - minim), 3);

Console.WriteLine("Разница между максимальным и минимальным числами массива равна " +  difference);
Console.WriteLine();
*/