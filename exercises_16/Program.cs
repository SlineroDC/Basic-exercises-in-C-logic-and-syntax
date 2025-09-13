// See https://aka.ms/new-console-template for more information

string text = "Hello";
string tex2 = "C#!";
string combinedText = string.Concat(text, " ", tex2);
int length = combinedText.Length;
Console.WriteLine($"the combined text is: {combinedText}");
Console.WriteLine($"The length of the combined text is: {length}");