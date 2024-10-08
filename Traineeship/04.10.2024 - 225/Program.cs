/*Напишіть програму для створення таблиці множення (від 1 до 10) 
 * для введеного цілого числа n.

Вхідні дані:

3
Вихідні дані:

3 x 1 = 3
3 x 2 = 6
3 x 3 = 9
3 x 4 = 12
3 x 5 = 15
3 x 6 = 18
3 x 7 = 21
3 x 8 = 24
3 x 9 = 27
3 x 10 = 30*/
 
Console.WriteLine("Please, enter the n");
string step1 = Console.ReadLine();
string result = "";
string x = "x";
string eq = "=";
string multi = "";
int numb = int.Parse(step1);
int resultMulti = 0;
string multResult = "";
for(int i = 1; i<=10; i++)
{
    multi = i.ToString();
    resultMulti = numb* i;
    result = resultMulti.ToString();
    multResult = step1 + x + multi + eq + result;
    Console.WriteLine(multResult);
}