/*Напишіть програму для побудови шаблону як у вихідних даних за введеним значенням n.

Вхідні дані:

5
Вихідні дані:

*****
****
***
**
*

 */

Console.WriteLine("Please, enter the n");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
var result = "";
var ofResult = "";
for (int x = 0; x < n; x++)
{
    result += "*";
}
for (int i = 0; i < result.Length; i++)
{
    ofResult = result.Substring(i, result.Length - i);
    Console.WriteLine(ofResult);
}