/*Напишіть програму для побудови шаблону як у вихідних даних за введеним значенням n.

Вхідні дані:

9
Вихідні дані:

1
22
333
4444
55555
666666
7777777
88888888
999999999
*/

Console.WriteLine("Please, enter the n");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
var result = "";
for (int i = 1; i <= n; i++)
{ 
    result += i;
    Console.WriteLine(result);
} 