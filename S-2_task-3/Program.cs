﻿//Task3
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Write("Введите первое, большее число: ");
int num31 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num32 = Convert.ToInt32(Console.ReadLine());
if (num31 % num32 != 0){
    Console.Write("Не кратно, остаток ");
    Console.WriteLine(num31 % num32);
}
else{
    Console.WriteLine("Кратно");
}