﻿//Console.WriteLine("Input number");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Quad of {a} -> {a * a}");//"You input this number ->" + a
//int quad = a * a;
//Console.WriteLine(quad);
//Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//Console.WriteLine("Input first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second number");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num2 * num2 == num1)
//{
  //  Console.WriteLine($"Fisrt number {num1} is quad of second number {num2}");
//}
//else

   //  Console.WriteLine($"Fisrt number {num1} is not quad of second number {num2}");

// Задача 3.  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

//Console.WriteLine("Input N");
//int n = Convert.ToInt32(Console.ReadLine());

//int current = n *(-1);
//while(current <= n)
//{
  //  Console.WriteLine(current + " ");
    //current++;
//}

// Задача 4.  Напишите программу, которая на вход принимает трехзначное число и на выходе показывает **последнюю** цифру этого числа.

// 456 -> 6

// 782 -> 2

// 918 -> 8

//Console.WriteLine("Input three-digit number");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num >= 100 && num <= 999)
//{
//int reminder = num % 10;
//Console.WriteLine($"Last digit {num} -> {reminder}");
//}
//else
//{
  //  Console.WriteLine("You input not three-digit number");
//}
