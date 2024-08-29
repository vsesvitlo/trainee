// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, enter positive number with a remainder ");
string step1 = Console.ReadLine();
int step2 = int.Parse(step1);
double step3 = Convert.ToDouble(step2);
double step4 = Math.Round(step3, 2);
Console.WriteLine(step4);