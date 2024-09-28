/*207 Надрукувати у рядку m разів число n. 
 * Числа m і n - цілі числа, які вводить користувач у порядку n, m.

Вхідні дані:

10
5
Вихідні дані:

10 10 10 10 10*/
Console.WriteLine("Please, enter the n - number");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
Console.WriteLine("Please, enter the m - the quantity of numbers");
string step2 = Console.ReadLine();
int m = int.Parse(step2);
string result = "";
for (int i = m; i > 0; i--)
{
    string nStr = n.ToString() + " ";
    result += nStr;
}
Console.WriteLine(result);