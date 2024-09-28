/*Користувач вводить кількість навчальних предметів n, 
 * а потім, відповідно, оцінки учня з n навчальних предметів. Визначте середню оцінку.

Вхідні дані:

5
10
11
9
8
10
Вихідні дані:

9.60 ???*/
Console.WriteLine("Please, enter the number - the quantity of subjects");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
double allMarks = 0;
double result = 0;
for (int i = n; i > 0; i--)
{
    Console.WriteLine("Please, enter your mark for the subject");
    string step2 = Console.ReadLine();
    double mark = double.Parse(step2);
    allMarks += mark;
    
    result = Math.Round((allMarks / n), 2);
}
//result = allMarks / n ;
Console.WriteLine(result);