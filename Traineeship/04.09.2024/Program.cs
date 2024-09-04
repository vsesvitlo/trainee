// See https://aka.ms/new-console-template for more information
/*Знайти кількість відрізків b, розміщених на відрізку a,
 * і довжину незайнятої частини на відрізку a. Користувачем
 * вводиться довжина відрізка a, а потім довжина відрізка b на окремих рядках. 
 * Відповідь виводиться в одному рядку: кількість відрізків b і довжина незайнятої частини відрізка a.
 
 121
11

 11 
0*/

Console.WriteLine("Please, enter the length a - the longest");
string step1 = Console.ReadLine();
int longest = int.Parse(step1);
Console.WriteLine("Please, enter the length b - the shortest");
string step2 = Console.ReadLine();
int shortest = int.Parse(step2);
int quantity = longest / shortest;
int rests = longest % shortest;

Console.WriteLine($"{quantity},{rests}");