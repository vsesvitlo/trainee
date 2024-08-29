// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, enter any number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter any number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter any number lower than previous");
int c = int.Parse(Console.ReadLine());
int result1 = a + b + c;
int result2 = a * b * c;
double result3 = Math.Pow(a, (b - c));

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);
