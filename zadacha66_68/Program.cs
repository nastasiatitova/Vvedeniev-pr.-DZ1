// 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());

int Number(int m, int n)
{int sum = m;
    if (m == n)
    return sum;
    return sum + Number(m + 1, n);
}

Console.Write("Сумма чисел =  ");
Console.WriteLine(Number(m, n));


// 68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());

int Akk(int m, int n)
{
if (m == 0) 
return n + 1;
else 
if (m > 0 && n == 0)
return Akk(m - 1, 1);
else
return Akk(m - 1, Akk(m, n - 1)); 
}

Console.WriteLine();
Console.WriteLine("Значение функции = " + Akk(m, n));
*/