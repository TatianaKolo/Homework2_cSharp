﻿// See https://aka.ms/new-console-template for more information

int number = new Random().Next(100, 999);

System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

System.Console.WriteLine();