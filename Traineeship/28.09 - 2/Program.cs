/*Завдання 8: Отримання підрядка
Напиши програму, яка отримує підрядок з введеного рядка, використовуючи метод Substring.
Вхід: ("Hello, World!", startIndex: 7, length: 5)->Вихід: ("World")
*/

Console.WriteLine("Please, enter any word");
string step1 = Console.ReadLine();
Console.WriteLine("Please, startIndex:");
string step2 = Console.ReadLine();
Console.WriteLine("Please, enter any length:");
string step3 = Console.ReadLine();
int step4 = int.Parse(step2);
int step5 = int.Parse(step3);
string result = (step1.Substring(step4, step5));
Console.WriteLine(result);
