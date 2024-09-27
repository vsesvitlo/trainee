/*
 Завдання 5: Замінити всі голосні на зірочки
Напиши програму, яка замінює всі голосні (a, e, i, o, u) на символ *.
Вхід: ("Beautiful day")->Вихід: ("B**tfl d*y")

Пошук на цифри і заміна на зірочки
*/
Console.WriteLine("Please, enter any phrase");
string step1 = Console.ReadLine();

var step2 = step1;
for (int i = 0; i < step2.Length; i++)
{
    /*if ((step1[i] == 97 || step1[i] == 65))
    {
       step2 += step1.Replace('a', '*');
    }
    else if ((step1[i] == 101 || step1[i] == 69))
    {
        step2 += step1.Replace('e', '*');
    }
    else if ((step1[i] == 105 || step1[i] == 73))
    {
    step2 += step1.Replace('i', '*');
    }
    else if ((step1[i] == 111 || step1[i] == 79))
    {
    step2 += step1.Replace('0', '*');
    }
    else if ((step1[i] == 117 || step1[i] == 85))
    {
    step2 += step1.Replace('u', '*');
    }
    else
    {
        Console.WriteLine(step2);
    }*/

    // step1 = s.Replace('a', 'b').Replace('b', 'c').Replace('c', 'd');
    // Console.WriteLine($"The final string: '{s}'");
    
   
     if (step2[i] == 97 || step2[i] == 101 || step2[i] == 105 || step2[i] == 111 ||
        step2[i] == 117 || step2[i] == 65 || step2[i] == 69 || step2[i] == 73 ||
        step2[i] == 79 || step2[i] == 85)
     {
        //step1[i] = 42;
        step2 = step2.Replace(step1[i], '*');
        
            //+ step1.Replace('e', '*') + step1.Replace('i', '*') + step1.Replace('0', '*') + step1.Replace('u', '*');

        //step2 = step1.Replace('a', '*') + step1.Replace('e', '*') + step1.Replace('i', '*') + step1.Replace('0', '*') +step1.Replace('u', '*');
        //Console.WriteLine( step1.Replace ('step[i]', '*'));
        //string check1 = step1.Substring(step1.Length - 1, 1);
        // Console.WriteLine(check1);
        //string test1 = step1.Substring(1, step1.Length - 1);
        // Console.WriteLine(test1);
    }
}
Console.WriteLine(step2);