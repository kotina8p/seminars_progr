﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.Write("Введите первое целое число: ");
int number0 = Convert.ToInt32(Console.ReadLine()); // -2 147 483 648 до 2 147 483 647
Console.Write("Введите второе целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // -2 147 483 648 до 2 147 483 647
if(number0 == number1 * number1)
{
     Console.Write($"Число {number0} является квадратом числа {number1}");
}
else
{
    Console.Write($"Число {number0} не является квадратом числа {number1}");
}    

