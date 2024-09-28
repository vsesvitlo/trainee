/*Напишіть програму-таймер зворотного відліку, 
 * яка запитує у користувача кількість секунд n, з якої слід починати відлік.

Вхідні дані:

5*/
Console.WriteLine("Please, enter the number - the quantity of time (seconds)");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
for(int i = n; i > 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Start!");