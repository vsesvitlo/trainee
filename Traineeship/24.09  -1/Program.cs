/*
 * Завдання 4: Видалення зайвих пробілів
Напиши програму, яка видаляє всі зайві пробіли (з початку, кінця та між словами).
Вхід: (" C# is great ")->Вихід: ("C# is great")


Пропуск перед і до на пропуск і 2 пропуска??
*/

Console.WriteLine("Please, enter any phrase");
string step1 = Console.ReadLine();
string step2 = "";
if((step1[step1.Length - 1] == 35) || (step1[0] == 35))
{
    step2 += step1.Substring(step1[1], step1[step1.Length -1]);
    //string check1 = step1.Substring(step1.Length - 1, 1);
    for (int i = 0; i < step1.Length; i++)
{
    //if ((step1[i] == 35 && step1[i+1] == 35) || 
    //  step2 += step1.Substring( );
     //Console.WriteLine(step2);

    //}
}
}
Console.WriteLine(step2);
