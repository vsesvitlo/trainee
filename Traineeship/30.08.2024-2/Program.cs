// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, enter radiant circle value (fractional number)");
string step1 = Console.ReadLine();
double step2 = Convert.ToDouble(step1);
double s = Math.Round(Math.PI * Math.Pow(step2, 2), 2);
double len = Math.Round((2 * Math.PI * step2), 3);
Console.WriteLine(s);
Console.WriteLine(len);