﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());

if ((number == 6) || (number == 7))
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Не выходной");
}
