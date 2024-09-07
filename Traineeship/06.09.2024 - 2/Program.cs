// See https://aka.ms/new-console-template for more information
/*104 Напишіть програму, яка виводить назви введених чисел.
 * Користувач вводить ціле число. Якщо це число або 1 або 2 або 3, 
 * то виводиться повідомлення - назва числа, відповідно, One, Two, Three. 
 * В усіх інших випадках виводиться слово Unknown.
20
1
2
3

Unknown
One
Two
Three
*/

using System.Linq.Expressions;

Console.WriteLine("Please, enter the number");
string step1 = Console.ReadLine();
int numberStep2= int.Parse(step1);

switch (numberStep2)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    default:
        Console.WriteLine("Unknown");
        break;
}