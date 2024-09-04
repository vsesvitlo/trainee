// See https://aka.ms/new-console-template for more information
/*59
Вводиться додатне ціле трицифрове число. Знайти суму цифр числа.
153
123
565

9
6
16*/
using System;

Console.WriteLine("Please, enter a positive whole three-digit number");
string step1 = Console.ReadLine();
//int step2 = int.Parse(step1);
int sum = 0;
int sum2 = 0;
int sum3 = 0;
string check1 = step1.Substring(step1.Length - 1, 1);
string check2 = step1.Substring(step1.Length - 2, 1);
string check3 = step1.Substring(step1.Length - 3, 1);
sum = Convert.ToInt32(check1) + Convert.ToInt32(check2) + Convert.ToInt32(check3);
/*for (int i = 1; i < step1.Length-1; i++)
{
    string check4 = step1.Substring(step1.Length - i, i);
    int convert = Convert.ToInt32(check4);
    sum2 += convert;
    Console.WriteLine(sum2);
    //Console.WriteLine(step1[i].GetType());
    //Console.WriteLine(sum.GetType());
}*/

//Console.WriteLine(check);
//Console.WriteLine(sum.GetType());
Console.WriteLine(sum);
//Console.WriteLine(sum3);