﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2 == 0)
{
  Console.WriteLine("Число" + " " + number + " " + "четное");  
}
else
{
    Console.WriteLine("Число" + " " + number + " " + "не четное"); 
}