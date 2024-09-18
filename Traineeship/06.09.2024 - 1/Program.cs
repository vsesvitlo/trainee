// See https://aka.ms/new-console-template for more information
/*103
Користувачем вводиться два імені.
Використовуючи конструкцію розгалуження 
програма повинна вивести імена в алфавітному порядку.

 Guido van Rossum
Dennis Ritchie

 Dennis Ritchie
Guido van Rossum*/

Console.WriteLine("Please enter the name");
string step1 = Console.ReadLine();
Console.WriteLine("Please enter the name");
string step2 = Console.ReadLine();

string new1 = step1.Substring(0, 1);
string new2= step2.Substring(0, 1);
var a = "";
/*
for (int i = 0; i < step1.Length; i++)
{
    for (int j = 0; j < step2.Length; j++)
    {
        if (step1[i] > step2[j])
        {
            a = step2 + " " + step1;
        }
         else if(step1[i] == step2[j])
        {
            a = "They equal!";
        }
        else
        {
            a = step1 + " " + step2;
        }
    }
    
}
Console.WriteLine(a);
//Console.WriteLine(step1, step2);
//Console.WriteLine(new1);
//Console.WriteLine(new2);
*/

string[] characters = { step1, step2 };
    Array.Sort(characters);
Console.WriteLine(characters[0] + " " + characters[1]);
