﻿//21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine()
double result = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
Console.WriteLine($"Расстояние равно: {result}");

