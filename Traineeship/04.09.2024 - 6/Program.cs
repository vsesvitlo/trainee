// See https://aka.ms/new-console-template for more information
/*77
 Виконайте перетворення значення температури у градусах Цельсія (С) 
для інших температурних шкал: Фаренгейта (F) і Кельвіна (K). Програма повинна відображати еквівалентну 
температуру у градусах Фаренгейта (F = 32 + 9/5 * C) і у градусах Кельвіна (K = C + 273,15).*/


//25 Celsius = 77.000 Fahrenheit = 298.150 Kelvin

Console.WriteLine("Please enter the Celsius degree");
string step1 = Console.ReadLine();

double c = Convert.ToDouble(step1);

double a = 1.8;

Console.WriteLine(a);
double f = Math. Round((32 + (a * c)), 3);
double k = Math.Round( (c + 273.15), 3);
Console.WriteLine(@$"{c} Celsius = {f} Fahrenheit = {k} Kelvin");
   