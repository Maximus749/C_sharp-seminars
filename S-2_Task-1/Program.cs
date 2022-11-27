//Task1
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//Например:
//78 -> 8
//12-> 2
//85 -> 8

int num11 = new Random().Next(10, 99);
int firstNum = num11 / 10;
int secondNum = num11 % 10;

if (firstNum > secondNum) 
{
    Console.WriteLine(num11 + " " + firstNum);
}
else{
     Console.WriteLine(num11 + " " + secondNum);
}
