//string name1 = "Bob";
//string name2 = "Ann";
//string name3 = "Liz";
//string name4 = "John";
//string name5 = "Smith";

string []names = new string[5]{"Bob", "Ann", "Liz", "John", "Smith"};
int []numbers = new int[5];


//Перебираем массив
for (int i = 0; i < numbers.Length; i++){
    Console.WriteLine(numbers[i]);
}
Console.WriteLine("--------------------");

names[0] = "Bob1";  //меняем значение элемента
names[2] = "Liza";


for (int i = 0; i < names.Length; i++){
    Console.WriteLine(names[i]);
}

Console.WriteLine("--------------------");

foreach(string n in names){
    Console.WriteLine(n);
}

