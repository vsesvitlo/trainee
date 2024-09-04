// See https://aka.ms/new-console-template for more information
/* 76 Припустимо, учнівські канікули тривали кілька днів. 
 * Напишіть програму, на вхід якої подається кількість днів,
 * а на екран виводиться у відформатованому вигляді
 * (вирівнювання за лівим краєм, ширина поля: 10 знаків) 
 * загальна тривалість канікул у годинах, хвилинах, секундах.
 15

 360        hours
21600      minutes
1296000    seconds*/

Console.WriteLine("Please, enter the quantty of days - holidays");
string step1 = Console.ReadLine();
int days = int.Parse(step1);

int hours = days * 24;
int minutes = hours * 60;
int seconds = minutes * 60;

Console.WriteLine($"{hours}, {minutes}, {seconds}");
//Console.WriteLine(String.Format("|{hours}|{minutes},|{seconds}|", hours, minutes, seconds ));


