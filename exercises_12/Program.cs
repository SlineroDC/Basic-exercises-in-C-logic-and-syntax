// See https://aka.ms/new-console-template for more information

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number > 0)
{
    Console.WriteLine($"{number} is positive");
}
else if (number < 0)
{
    Console.WriteLine($"{number} is negative");
}
else
{
    Console.WriteLine("The number is zero");
}