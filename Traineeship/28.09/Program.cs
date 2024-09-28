/*Завдання 7: Підрахунок входжень символа
Напиши програму, яка підраховує кількість входжень заданого символа у рядку.
Вхід: ("programming", 'g')->Вихід: ("2")*/

Console.WriteLine("Please, enter any word");
string step1 = Console.ReadLine();
Console.WriteLine("Please, enter any letter");
string step2 = Console.ReadLine();
int calc = 0;
for (int i = 0; i < step1.Length; i++)
{
    if (step1[i] == step2[0])
    {
        calc++;
    }
}
Console.WriteLine(calc);