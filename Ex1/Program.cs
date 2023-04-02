﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine()!);

while (number > 100)
{
    number = number / 10;
}
int number2 = number % 10;

Console.WriteLine($"Вторая цифра {number2}");