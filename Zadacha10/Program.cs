// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number>99)
{
    Console.WriteLine("Вторая цифра числа - " + (number % 100) / 10);
}
else Console.WriteLine("Неверное число. Введите трехзначное число");