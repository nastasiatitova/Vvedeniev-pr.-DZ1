//Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int i = 0;
int newnum = 0;
int ostatok = 0;

Console.WriteLine("Перевенутое число ");
for (i = number; i > 0; i = i / 10)
{
    ostatok = i % 10;
    Console.Write(ostatok);
    newnum = newnum *10 + ostatok;
}
Console.WriteLine();
if (newnum == number)
{
    Console.WriteLine("Число полиндром");
}
else Console.WriteLine("Число не полиндром");

