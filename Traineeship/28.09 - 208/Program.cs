/*Напишіть програму для виведення усіх цілих чисел від 20 до n включно (n > 20),
 * де n - ціле число, яке вводить користувач.

Вхідні дані:

25
Вихідні дані:

20
21
22
23
24
25
*/

Console.WriteLine("Please, enter the n - number > 20");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
if (n >= 20)
{
     for (int i = 20; i <= n; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Please, enter the n more than 20");
}
