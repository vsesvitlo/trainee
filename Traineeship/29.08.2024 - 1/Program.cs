// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, enter decimal positive number ");
string step1 = Console.ReadLine();
int step2 = int.Parse(step1.Substring(step1.Length-2, 1));
Console.WriteLine(step2);
int step3 = int.Parse(step1);
double step4 = Convert.ToDouble(step3);
double step5 = (step4 - (step4 % 10)) / 10;
Console.WriteLine(step5);
