// See https://aka.ms/new-console-template for more information
/*Дано натуральне число. Знайдіть цифру, що стоїть в розряді
 * десятків в десятковому записі числа (друга цифра, якщо рахувати з кінця запису).*/
Console.WriteLine("Please, write the whole positive number");
string step1 = Console.ReadLine();
if (step1.Length > 1)
{
    int step2 = int.Parse(step1.Substring(step1.Length - 2, 1));
    Console.WriteLine(step2);
}
Console.WriteLine(0);

