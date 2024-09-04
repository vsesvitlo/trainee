// See https://aka.ms/new-console-template for more information
/*61
Оленка дізналася, що їй для сну треба t хвилин. 
На відміну від Тетяни, Оленка лягає спати після опівночі в h годин і m хвилин.
Допоможіть Оленці визначити, на який час їй поставити будильник,
щоб він продзвенів рівно через t хвилин після того, як вона ляже спати. 
В окремомих рядках вводяться значення t, h і m відповідно.
Гарантується, що Оленка повинна прокинутися в той же день, що і заснути.
Програма повинна виводити час, на який потрібно поставити будильник:
в першому рядку години, в другому - хвилини.

430
1
40

8
50
*/

Console.WriteLine("Please, enter t - the time in minutes for Olenka");
string step1 = Console.ReadLine();
int t = int.Parse(step1);
Console.WriteLine("Please, enter h - the hour at which Olenka goes to bed");
string step2 = Console.ReadLine();
int h = int.Parse(step2);
Console.WriteLine("Please, enter i - the minutes at which Olenka goes to bed");
string step3 = Console.ReadLine();
int i = int.Parse(step3);

int hours = t / 60;
int minutes = t % 60;

int newHours = hours + h;
int newMinutes = minutes + i;
if(newMinutes >= 60)
{
    newHours += 1;
    newMinutes -= 60;
}
Console.WriteLine(newHours);
Console.WriteLine(newMinutes);