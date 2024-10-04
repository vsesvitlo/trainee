/*Надрукувати всі непарні двоцифрові числа, 
 * у яких остання цифра дорівнює n - ціле число, 
 * яке вводить користувач.

Вхідні дані:

5
1
0
Вихідні дані:

15 25 35 45 55 65 75 85 95
11 21 31 41 51 61 71 81 91
10 20 30 40 50 60 70 80 90*/

Console.WriteLine("Please, enter the n");
string step1 = Console.ReadLine();
string result = "";
for (int i = 1; i <= 9; i++)
{
    result = i.ToString() + step1;
    Console.WriteLine(result);
}