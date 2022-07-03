// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


using System;
using static System.Console;

Clear();
WriteLine("Введите пятизначное число: ");
int a = int.Parse(ReadLine());

if ((a < 10000) || (a > 99999))
{
    WriteLine("введено некорректное число");
    return;
}

string str = a.ToString();
int[] b = new int[str.Length];
int i = 0;
for(i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
if(b[0] == b[4])
{
    if(b[1] == b[3])
    {
        WriteLine($"{a} -> да");
        return;
    }
    WriteLine($"{a} -> нет");
    return;
}
WriteLine($"{a} -> нет");
