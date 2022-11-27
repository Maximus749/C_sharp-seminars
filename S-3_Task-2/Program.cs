// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите № четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1) Console.WriteLine("x от 0 до бесконечности, y от 0 до бесконечности.");
if (quarter == 2) Console.WriteLine("x от 0 до '-' бесконечности, y от 0 до бесконечности.");
if (quarter == 3) Console.WriteLine("x от 0 до '-' бесконечности, y от 0 до '-' бесконечности.");
if (quarter == 4) Console.WriteLine("x от 0 до бесконечности, y от 0 до '-' бесконечности.");