﻿/*Завдання 1: Реверсування строки
Напиши програму, яка приймає строку і виводить її у зворотному порядку.
Вхід: ("Hello, World!") -> Вихід: ("!dlroW ,olleH")

Цикл як для чисел або метод reverse */

Console.WriteLine("Please, enter any sentence");
string step1 = Console.ReadLine();
char[] arr = step1.ToArray();
var a = "";
arr = arr.Reverse().ToArray();
Console.WriteLine(arr);


for(int i = step1.Length - 1; i >= 0; i--)
{
    a += step1[i];
}
//Console.WriteLine(a);