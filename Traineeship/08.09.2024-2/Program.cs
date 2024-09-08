// See https://aka.ms/new-console-template for more information
/*110
Дано маси і об’єми двох тіл, виготовлених з різних матеріалів (дійсні числа). 
Матеріал якого з тіл має більшу густину? Введення величин відбувається у такому порядку: m1, v1, m2, v2.

 
 2
3.5
1.5
2.3

1.5 2.3
*/
Console.WriteLine("Please, enter the weight - m1 of the first object");
string step1 = Console.ReadLine();
double m1 = Convert.ToDouble(step1);
Console.WriteLine("Please, enter the value - v1 of the first object");
string step2 = Console.ReadLine();
double v1 = Convert.ToDouble(step2);
Console.WriteLine("Please, enter the weight - m1 of the first object");
string step3 = Console.ReadLine();
double m2 = Convert.ToDouble(step3);
Console.WriteLine("Please, enter the value - v2 of the second object");
string step4 = Console.ReadLine();
double v2 = Convert.ToDouble(step4);

double density1 = m1 * v1;
double density2 = m2 * v2;
if (density1 < density2)
{
    Console.WriteLine(m2);
    Console.WriteLine(v2);
}
else if(density1 > density2)
{
    Console.WriteLine(m1);
    Console.WriteLine(v1);
}
else
{
    Console.WriteLine("Equal!");

}