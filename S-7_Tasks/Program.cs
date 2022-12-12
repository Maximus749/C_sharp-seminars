// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
//-----------------------------------------------------------------------------------------
// int[,] CreateArray(int row, int col)
// {
//     int[,] arr = new int[row, col];
//     for(int i = 0; i < arr.GetLength(0); i++){
//         for (int j = 0;j < arr.GetLength(1); j++){
//             arr[i, j] = new Random().Next(0, 100);
//         }
//     }
//     return arr;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//     }
//     Console.WriteLine();
// }
// int[,] matrix = CreateArray(3, 4);
// PrintArray(matrix);
//==============================================================================================
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
//по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
//-----------------------------------------------------------------------------------------
// int[,] CreateArray(int row, int col)
// {
//     int[,] arr = new int[row, col];
//     for(int i = 0; i < arr.GetLength(0); i++){
//         for (int j = 0;j < arr.GetLength(1); j++){
//             arr[i, j] = i + j;
//         }
//     }
//     return arr;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = CreateArray(m, n);
// PrintArray(matrix);
//=============================================================================================
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//-----------------------------------------------------------------------------------------
// int[,] CreateArray(int row, int col)
// {
//     int[,] arr = new int[row, col];
//     for(int i = 0; i < arr.GetLength(0); i++){
//         for (int j = 0;j < arr.GetLength(1); j++){
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return arr;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void ReplaceElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i % 2 == 0 && j % 2 == 0){
//                 Console.Write($"{array[i, j] * array[i, j]} ");
//             }
//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = CreateArray(m, n);
// PrintArray(matrix);
// Console.WriteLine();
// ReplaceElements(matrix);
//===========================================================================================
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
//диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
//-----------------------------------------------------------------------------------------
int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for(int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0;j < arr.GetLength(1); j++){
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ReplaceElements(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (i == j){
                Console.Write($"{array[i, j]} ");
                count += array[i, j];
            }
        }
    }
    Console.WriteLine($" = {count}");
}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateArray(m, n);
PrintArray(matrix);
Console.WriteLine();
ReplaceElements(matrix);