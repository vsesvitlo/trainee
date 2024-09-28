/*Завдання 9: Перевірка наявності слова на початку рядка
Напиши програму, яка перевіряє, чи починається рядок з певного слова.
Вхід: ("Welcome to C# programming", слово: "Welcome")->Вихід: ("True")
Вхід: ("Hello World", слово: "Welcome")->Вихід: ("False")*/
Console.WriteLine("Please, enter any sentence");
string step1 = Console.ReadLine();
Console.WriteLine("Please, enter word for check");
string step2 = Console.ReadLine();
bool isCheck = true;
for (int i = 0, j = 0; j < step2.Length;  i++, j++)
{
    if (step1[i] != step2[j]) {
        isCheck = false;
    }
}
Console.WriteLine(isCheck);