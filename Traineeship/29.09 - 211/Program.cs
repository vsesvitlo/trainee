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
var resultLine = "";
var resultInLine = "";
var check = "";
for (int j = 1; j <= n; j++)
{
    resultInLine = "";
    for(int l = 0; l < j; l++)
    {
        resultInLine += j;
    }

    Console.WriteLine(resultInLine);
}


//Console.WriteLine(resultInLine);

//for (int i = 1; i <= int.Parse(resultInLine); i++)
//{
//for (int k = int.Parse(resultInLine); k <= n; k++)
//{

//  resultLine += k;
// }
//resultLine = resultInLine.ToString();
// resultLine += string.Concat(i,j);

//Console.WriteLine(resultLine);
// }
//check += resultInLine;