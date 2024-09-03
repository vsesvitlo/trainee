// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, enter positive number with a remainder ");
string step1 = Console.ReadLine();
double step3 = Convert.ToDouble(step1);
double step4 = Math.Round(step3, 2);
Console.WriteLine(step4);