// // Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



using System;
using static System.Console;

Clear();

WriteLine("Введите число N:");
int N = Int16.Parse(ReadLine());
int count = 1;
Write($"{N} -> ");

// for(count == 1, count <= N, count++)
while (count <=N)
{
    double cube = Math.Pow(count, 3);
    count++;
    Write($"{cube}, ");
}
