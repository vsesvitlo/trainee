// See https://aka.ms/new-console-template for more information
/*60
Тетяна кожен день лягає спати рівно опівночі і нещодавно дізналась,
що оптимальний час для її сну становить t хвилин. Тетяна хоче поставити
собі будильник так, щоб він продзвенів рівно через t хвилин після півночі,
однак для цього необхідно вказати час сигналу у форматі години і хвилини. 
Допоможіть Тані визначити, на який час завести будильник. Години і хвилини у 
виведенні програми повинні розташовуватися на різних рядках.
450

7
30
*/
Console.WriteLine("Please, enter the time in minutes for Tetiana");
string step1 = Console.ReadLine();
int step2 = int.Parse(step1);
int hours = 450 / 60;
int minutes = 450 % 60;
Console.WriteLine(hours);
Console.WriteLine(minutes);