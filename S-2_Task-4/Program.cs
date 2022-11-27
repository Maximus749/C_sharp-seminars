//Task4
//14Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.

//14 -> нет 
//46 -> нет 
//161 -> да

Console.Write("Введите число: ");
int num41 = Convert.ToInt32(Console.ReadLine());
int num42 = 7;
int num43 = 23;
if ((num41 % num42 == 0) &&  (num41 % num43 == 0)){
    Console.WriteLine("Кратно");
}
else {
    Console.WriteLine("Не кратно");
}