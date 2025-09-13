// See https://aka.ms/new-console-template for more information

Console.Write("enter your name: ");
string name = Console.ReadLine() ?? "";
Console.Write("enter your age: ");
string ageInput = Console.ReadLine() ?? "0";
int age = int.Parse(ageInput); 
Console.WriteLine($"Hello {name}, you are {age} years old.");