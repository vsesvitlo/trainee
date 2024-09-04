// See https://aka.ms/new-console-template for more information
/*Мама спекла пиріг з яблуками, в якому було 60% яблук, а решта - тісто. 
 При цьому 30% тіста становили яйця і цукор, решта - борошно.
 Вся маса пирога дорівнює m кг. Яка маса борошна в пирозі в грамах?
1.2
1
1.5

336.0
280.0
420.0
 */


Console.WriteLine("Please, enter m - weight of pie");
string step1 = Console.ReadLine();
double m = Convert.ToDouble(step1);

double forApplesIndex = 0.6;
double forDoughIndex= 1 - forApplesIndex;

double forDough = m * forDoughIndex; 
double forEggsSugar = 0.3 * forDough;
double forFlour = Math.Round(forDough - forEggsSugar, 3);
Console.WriteLine(forFlour * 1000);

