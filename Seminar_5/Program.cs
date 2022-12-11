// string s1 ="Bob";
// string s2 = "Mary";
// string s3 = s1 + " - " + s2;

// string s4 = string.Concat(s2, " - ", s1);
// Console.WriteLine(s3);
// Console.WriteLine(s4);

// int num = 123;
// string sNum = Convert.ToString(num);

// int s3Len = s3.Length;
// Console.WriteLine(s3Len);
// Console.WriteLine(s3);

// string[] names = {"Bob", "Ann", "Lis", "Myke"};
// int[] ages = {10, 17, 15, 12};
// string s10 = string.Join(" ", names);
// Console.WriteLine(s10);
// string s11 = string.Join("---", ages);
// Console.WriteLine(s11);

// ввод с консоли в массив
// Console.Write("Insert number: ");
// string s = Console.ReadLine();
// // string s = "1, 2, 3, 4, 5, 6, 7.";
// string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
// // foreach (var num in nums){
// //     Console.WriteLine($"Значение: {num}");
// // }
// int[] n = nums.Select(Int32.Parse).ToArray();
// foreach (var i in n){
//     Console.WriteLine($"{i} ");
// }
//===============================================================================
// int[] arrayNums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// foreach (var num in arrayNums)
// {
//     Console.WriteLine($"{num}  ");
// }
