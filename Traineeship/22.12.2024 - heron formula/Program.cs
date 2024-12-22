/*Write function heron which calculates the area of a triangle with sides a, b, and c (x, y, z in COBOL).

Heron's formula:

s
∗
(
s
−
a
)
∗
(
s
−
b
)
∗
(
s
−
c
)
s∗(s−a)∗(s−b)∗(s−c)
​
 
where

s
=
a
+
b
+
c
2
s= 
2
a+b+c
​
 
Output should have 2 digits precision.*/
namespace _22._12._2024___heron_formula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 4;   
            double c = 5;
            double result = Kata.Heron(a,b, c); //6
            Console.WriteLine(result);
        }
    }
    public class Kata
    {
        public static double Heron(double a, double b, double c)
        {

            double s = Math.Round(((a + b + c) / 2), 2);
            double result = Math.Round(Math.Sqrt(s * (s - a) * (s - b) * (s - c)), 2);
            return result;
        }
    }
}
