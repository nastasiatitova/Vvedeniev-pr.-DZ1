// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxim = number1;
if (number2 > maxim)
{
    Console.WriteLine("Максимальное число" + " " + number2);
}
else
{
    if (number3 > maxim)
    {
        Console.WriteLine("Максимальное число" + " " + number3);
    }
else
{
    Console.WriteLine("Максимальное число" + " " + number1);
}}