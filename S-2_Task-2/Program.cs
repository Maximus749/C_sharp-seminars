//Task2
//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

Console.Write("Введите трехзначное число: ");
int num21 = Convert.ToInt32(Console.ReadLine());
int firstNum2 = num21 / 100;
int thirdNum2 = num21 % 10;
int newNum2 = firstNum2 * 10 + thirdNum2;
Console.WriteLine(num21 + " " + newNum2);
