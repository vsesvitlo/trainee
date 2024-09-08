// See https://aka.ms/new-console-template for more information
/*111 
 * Серед учнів школи проводилося тестування з трьох предметів, 
 * по кожному з яких учні отримали певну кількість балів (цілі числа).
 * Напишіть програму, яку можуть використати учні для обчислення 
 * їхнього середнього балу трьох тестів і виведення середнього значення. 
 * Окрім того, необхідно передбачити виведення повідомлення 
 * Congratulations! That is a great average!, якщо середній бал більший ніж 95.
 143
112
135


130.00
Congratulations! That is a great average!
 */

Console.WriteLine("First mark");
string step1 = Console.ReadLine();
int m1 = int.Parse(step1);
Console.WriteLine("Second mark");
string step2 = Console.ReadLine();
int m2 = int.Parse(step2); 
Console.WriteLine("Third mark");
string step3 = Console.ReadLine();
int m3 = int.Parse(step3);

int result = (m1 + m2 + m3) / 3;

if(result > 95)
{
    Console.WriteLine(result);
    Console.WriteLine("Congratulations! That is a great average!");
}
else
{
    Console.WriteLine(result);
    Console.WriteLine("You should try more!");
}
