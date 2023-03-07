// 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*int PromptA()
{
Console.WriteLine("Введите число A");
return Convert.ToInt32(Console.ReadLine());
}
int PromptB()
{
Console.WriteLine("Введите число B");
return Convert.ToInt32(Console.ReadLine());
}

int numbera = PromptA();
int numberb = PromptB();


int Pow()
{   
    double st = 1;
    
      st = Math.Pow(numbera, numberb);

    return Convert.ToInt32(st);
}

int result = Pow();
Console.WriteLine(result);*/

//27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int Prompt()
{
Console.WriteLine("Введите число");
return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt();

int Sum()
{
   int sum = 0;
while (number>0)
{
   sum = sum + number%10;
   number /=10;
}
return sum;
}

int res = Sum();
Console.WriteLine(res); */

//29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int Prompt()
{
Console.WriteLine("Введите количество элементов массива");
return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

int [] CreatArray()
{
int[] array = new int [size];
for (int i = 0; i < size; i++)
{
   array[i] = new Random().Next(0,99);
}
return array;
}
int[] NewArray = CreatArray();

Console.WriteLine($"[{String.Join(", " , NewArray)}]");