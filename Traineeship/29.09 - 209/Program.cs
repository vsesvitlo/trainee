/*Напишіть програму для друку цілих чисел від n до 0 із 
 * виведенням біля кожного числа кількості символів #, що дорівнює значенню числа.

Вхідні дані:

6
Вихідні дані:

6 ######
5 #####
4 ####
3 ###
2 ##
1 #*/


//Not solved
Console.WriteLine("Please, enter the n");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
var result = "";
var ofResult = "";
for (int x = 0; x < n; x++)
{
    result += "#";
}
for (int i = 0; i < result.Length; i++)
{
   ofResult = result.Substring(i, result.Length - i);
   Console.WriteLine(n + ofResult);
    n--;
}

//Console.WriteLine(result);

/*for (int i = n; i > 0; i--)
{ 
    //for (int j = 0; j < n; j++) {
        
        result += "#";
        
    //}
    
    Console.WriteLine(i + result);
    // string nStr = i.ToString() + " " + j;
    //result = nStr;

*/