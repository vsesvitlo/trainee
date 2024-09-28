/*Визначити суму всіх чисел від 1 до n (1 ≤ n ≤ 100).

Вхідні дані:

100
16
1
Вихідні дані:

5050
136
1*/

Console.WriteLine("Please, enter the n");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
int result = 0;
for(int i = 0; i <= n; i++)
{
    result += i;
}
Console.WriteLine(result);