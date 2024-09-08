// See https://aka.ms/new-console-template for more information
/*109
Дано радіус кола і сторона квадрата (дійсні числа). У якої фігури площа більше?
2.5
3.5
3.6
7.5

Circle
Square
*/

Console.WriteLine("Please, enter the circle radius (real number)");
string step1 = Console.ReadLine();
double step2 = Convert.ToDouble(step1);
Console.WriteLine("Please, enter the square side (real number)");
string step3 = Console.ReadLine();
double step4 = Convert.ToDouble(step3);

double areaCircle = Math.PI * Math.Pow(step2,2);
double areaSquare = Math.Pow(step4,2);
//Console.WriteLine(areaCircle);
//Console.WriteLine(areaSquare);
if (areaCircle > areaSquare)
{
    Console.WriteLine("Circle");
}
 else if (areaCircle < areaSquare)
{
    Console.WriteLine("Square");
}
else
{
    Console.WriteLine("Equal");
}