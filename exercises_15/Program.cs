// See https://aka.ms/new-console-template for more information

Console.Write("enter a number a show the multiplication table of that number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<11; i++)
{
    int result = number * i;
    Console.WriteLine($"{number} x {i} = {result}");
}