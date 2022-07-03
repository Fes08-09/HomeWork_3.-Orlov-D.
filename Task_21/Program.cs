// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Легко использовать математическую формулу, чтобы найти расстояние между любыми двумя точками в 3D-пространстве, которое равно:√ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2. И это довольно легко вычислить для нахождения расстояния между любыми двумя точками в пространстве, где каждая точка имеет координаты (x, y z) в 3D-пространстве.

using System;
using static System.Console;

Clear();
WriteLine("Ниже введите координаты двух точек в 3D пространстве:");
WriteLine("Введите значение коорднат для Ax ");
int Ax = int.Parse(ReadLine());
WriteLine("Введите значение коорднат для Ay ");
int Ay = int.Parse(ReadLine());
WriteLine("Введите значение коорднат для Az ");
int Az = int.Parse(ReadLine());
WriteLine("Введите значение коорднат для Bx ");
int Bx = int.Parse(ReadLine());
WriteLine("Введите значение коорднат для By ");
int By = int.Parse(ReadLine());
WriteLine("Введите значение коорднат для Bz ");
int Bz = int.Parse(ReadLine());

double x = Math.Pow((Ax - Bx), 2);
double y = Math.Pow((Ay - By), 2);
double z = Math.Pow((Az - Bz), 2);

double distance = Math.Sqrt(x + y + z);
WriteLine($"A ({Ax}, {Ay}, {Az}); B ({Bx}, {By}, {Bz}) -> {distance:f2}");