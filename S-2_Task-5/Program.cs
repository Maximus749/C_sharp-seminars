//Task5
//16Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.Write("Введите первое число: ");
int num51 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num52 = Convert.ToInt32(Console.ReadLine());
if ((num51 == num52 * num52) || (num52 == num51 * num51)){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}