/*Завдання 2: Підрахунок кількості символів у рядку
Напиши програму, яка підраховує кількість літер, цифр та пробілів у рядку.
Вхід: ("C# is awesome 2024!")  -> Вихід: ("Літери: 10, Цифри: 4, Пробіли: 2")

Цикл з пошуком діапазону і рахувати */

Console.WriteLine("Please, enter any sentence with numbers");
string step1 = Console.ReadLine();
var a = "";
int numbers = 0;
int letters = 0;
int spaces = 0;

for (int i = 0; i < step1.Length; i++)
{
    //Console.WriteLine(step1[i].GetType());

    if (step1[i] <= 57 && step1[i] >= 48)
    {
        numbers++;
    }
    else if ((step1[i] <=90 && step1[i] >= 65) || (step1[i] <= 122 && step1[i] >= 97))
    {
        letters++;
    }
    else if (step1[i] == 32)
    {
        spaces++;
    }
    else
    {
        Console.WriteLine("Something new");

       // a = "Літери: " + letters + ", Цифри: " + numbers + ", Пробіли: " + spaces;
    }

}
Console.WriteLine(numbers);
Console.WriteLine(letters);
Console.WriteLine(spaces);
Console.WriteLine($"Numbers:{numbers}; Letters: {letters}; Spaces: {spaces}.");

