// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();

if (number>99)
{
    Console.WriteLine("Третяя цифра числа - " + str[2]);
}
else Console.WriteLine("Третьей цифры нет");