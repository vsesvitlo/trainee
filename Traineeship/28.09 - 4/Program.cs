/*Завдання 10: Зміна регістру
Напиши програму, яка перетворює всі літери в рядку на великі або на малі.
Вхід: ("Hello, World!") -> Вихід: ("HELLO, WORLD!")
Вхід: ("Hello, World!") ->Вихід: ("hello, world!")*/


Console.WriteLine("Please, enter any sentence");
string step1 = Console.ReadLine();
Console.WriteLine("Please, choose uppercase - enter 1; lowcase - enter 2 ");
string step2 = Console.ReadLine();
int step3 = int.Parse(step2);
switch (step3)
{
    case 1:
        string step4 = step1.ToUpper();
        Console.WriteLine(step4);
        break;
    case 2:
        string step5 = step1.ToLower();
        Console.WriteLine(step5);
        break;
    default:
        Console.WriteLine("Please, enter 1 or 2");
        break;
}