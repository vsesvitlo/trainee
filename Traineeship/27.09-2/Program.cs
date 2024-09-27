/*Завдання 6: Розбиття рядка на слова
Напиши програму, яка розбиває рядок на окремі слова, використовуючи метод Split.
Вхід: ("C# is awesome!")->Вихід: ("C#", "is", "awesome!")


Split і пробіл
*/

Console.WriteLine("Please, enter any phrase");
string step1 = Console.ReadLine();

string[] step2 = step1.Split(' ');
//var a = "";
for(int i = 0; i < step2.Length; i++)
{
    Console.WriteLine(step2[i]);
}
