﻿Console.Clear();
Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");