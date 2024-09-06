// See https://aka.ms/new-console-template for more information
/*78
 Отримати реверсний (в зворотному порядку) запис введеного користувачем трицифрового числа.
184
481
*/
Console.WriteLine("Please enter the three-digit number");
string step1 = Console.ReadLine();
int size = step1.Length;
//string step2 = step1.Substring(step1.Length-1, 1);
string step2;
var a = "";
var b = "";
string step3;
int d = 0;
string result;
for (int i = 0; i < step1.Length; i++)
{
    a = step1.Substring(step1.Length - 1 - i, 1);
    b += a;
}

Console.WriteLine(b);


//string result = ;
//Console.WriteLine(step3);
/*
for (int y = step1.Length -1; y >=0; y--)
{
 for (int i = 0; i < step1.Length; i++)
    {
        
        d = Convert.ToInt32(step1[y]);
        Console.WriteLine(step1[y].GetType());
       
}
    step2 = Convert.ToString(d);
    Console.WriteLine(step2);
}


int c = int.Parse(step1);
*/

