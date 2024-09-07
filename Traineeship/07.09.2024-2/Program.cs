// See https://aka.ms/new-console-template for more information
/*Напишіть програму, в якій користувач вводить значення температури, 
 * і, якщо це значення менше або дорівнює 0 градусів Цельсія, 
 * необхідно вивести повідомлення A cold, isn’t it?.
 * Якщо ж температура становить більше 0 і менше 10 градусів 
 * Цельсія повідомлення буде Cool., у інших випадках Nice weather we’re having..
12.5
-5
9

Nice weather we're having.
A cold, isn't it?
Cool.
*/


Console.WriteLine("Please, enter the temperature");
string step1 = Console.ReadLine();

int temperatureStep2 = int.Parse(step1);

switch (temperatureStep2)
{
    case <= 0:
        Console.WriteLine("A cold, isn't it?");
        break;
    case < 10 :
        Console.WriteLine("Cool.");
        break;
    default:
        Console.WriteLine("Nice weather we’re having");
        break;
}