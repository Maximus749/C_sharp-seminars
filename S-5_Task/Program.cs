// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29, сумма отрицательных равна -20.
//-------------------------------------------------------------------------------------------
// int[] nums = new int[12];
// int negative = 0;
// int positive = 0;
// for (int i = 0; i < nums.Length; i++){
//     nums[i] = new Random().Next(-9, 10);
//     Console.Write($"{nums[i]} ,");
// }
// Console.WriteLine(" ");
// for (int i = 0; i < nums.Length; i ++){
//     if (nums[i] < 0) negative += nums[i];
//     if (nums[i] > 0) positive += nums[i];
// }
// Console.WriteLine($"Сумма положительных = {positive}, Сумма отрицательных = {negative}");
//=========================================================================================
// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
//-------------------------------------------------------------------------------------------
// int[] CreateArray(int lenght)
// {
//     int[] arr = new int[lenght];
//     for(int i = 0; i < lenght; i++){
//         arr[i] = new Random().Next(-10, 10);
//     }
//     return arr;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int[] ModifyArray(int[] ar)
// {
//     for (int i = 0; i < ar.Length; i++){
//         ar[i] = ar[i] * -1;
//     }
//     return ar;
// }
// int[] nums = CreateArray(4);
// PrintArray(nums);
// ModifyArray(nums);
// PrintArray(nums);
//=========================================================================================
// Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
//-------------------------------------------------------------------------------------------
// int[] nums = new int[5];
// for (int i = 0; i < nums.Length; i++){
//     nums[i] = new Random().Next(-9, 10);
//     Console.Write($"{nums[i]} ,");
// }
// Console.WriteLine(" ");
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int check = 0;
// for (int i = 0; i < nums.Length; i ++){
//     if (num == nums[i]){
//         Console.WriteLine("Yes");
//         check += 1;
//     }
// }
// if (check == 0) Console.WriteLine("No");
//=========================================================================================
// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
//-------------------------------------------------------------------------------------------
// int[] nums = new int[123];
// for (int i = 0; i < nums.Length; i++){
//     nums[i] = new Random().Next(1, 1000);
//     Console.Write($"{nums[i]} ,");
// }
// int count = 0;
// foreach (var num in nums){
//     if (num < 100 && num > 9) count += 1;
// }
// Console.WriteLine();
// Console.WriteLine($"Количество искомых элементов = {count}");
//==========================================================================================
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
//-------------------------------------------------------------------------------------------
// int[] CreateArray(int lenght)
// {
//     int[] arr = new int[lenght];
//     for(int i = 0; i < lenght; i++){
//         arr[i] = new Random().Next(1, 10);
//     }
//     return arr;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// int[] MultElements(int[] array1)
// {
//     int j = 0;
//     int lenght = 0;
//     if (array1.Length % 2 == 0){
//         lenght = array1.Length / 2;
//     }
//     else lenght = array1.Length / 2 + 1;
//     int[] array2 = new int[lenght];
//     for (int i = 0; i < array1.Length / 2; i++){
//         int k = (array1.Length - 1) - i;
//         array2[i] = array1[i] * array1[k];
//         j += 1;
//     }
//     if (array1.Length % 2 != 0) array2[j] = array1[j];
//     return array2;
// }
// // Console.Write("Введите длину массива: ");
// // int n = Convert.ToInt32(Console.ReadLine());
// int[] nums = CreateArray(5);

// PrintArray(nums);
// int[] nums2 = MultElements(nums);
// Console.Write(" -> ");
// PrintArray(nums2);
