// See https://aka.ms/new-console-template for more information


Console.WriteLine("Please, enter any positive number ");
string step1 = Console.ReadLine();
int step2 = int.Parse(step1.Substring(step1.Length - 1, 1));
Console.WriteLine(step2);