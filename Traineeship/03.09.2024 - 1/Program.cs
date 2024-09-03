// See https://aka.ms/new-console-template for more information
/*55.
    n студентів беруть k яблук і розподіляють між собою порівну. 
    Решта фруктів залишається в кошику. 
    Скільки яблук отримає кожен студент?
    Скільки яблук залишиться в кошику?
    Програма зчитує числа n і k і друкує на екрані дві відповіді на поставлені вище запитання.*/

Console.WriteLine("Please, enter n - how much students want to share apples?");
string step1 = Console.ReadLine();
Console.WriteLine("Please, enter k - how much apples are in the basket?");
string step2 = Console.ReadLine();
int step3n = int.Parse(step1);
int step3k = int.Parse(step2);
int step4resultEqual = step3k / step3n;
int step5resultRest = step3k % step3n;
Console.WriteLine(step4resultEqual);
Console.WriteLine(step5resultRest);
