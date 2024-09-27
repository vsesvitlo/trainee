/*Завдання 3: Перевірка на паліндром
Напиши програму, яка перевіряє, чи є введений рядок паліндромом.
Вхід: ("madam") ->Вихід: ("Це паліндром")
Вхід: ("hello")->Вихід: ("Це не паліндром")
*/

Console.WriteLine("Please, enter any word");
string step1 = Console.ReadLine();
string positiveResult = "It is the palindrome";
string negativeResult = "It is not the palindrome";
bool isPaindrome = true;

for (int i = 0, j = step1.Length - 1; i < step1.Length / 2; i++, j-- )
{
    if (step1[i] != step1[j])
        {
        isPaindrome = false;
        break;
        }
}
Console.WriteLine(isPaindrome? positiveResult: negativeResult);
