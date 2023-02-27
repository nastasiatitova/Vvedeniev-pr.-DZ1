// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число, соответствующее дню недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
   if (number == 6 || number ==7)
{
    Console.WriteLine("выходной");
}
else 
    Console.WriteLine("не выходной");
}
else
Console.Write("Вы ввели не верное число, поэтому не возможно определить");