/*Виведіть елементи даного списку в зворотному порядку, не змінюючи сам список.

Вхідні дані:

2 6 1 7 9
Вихідні дані:

9 7 1 6 2
*/
namespace _09._11._2024___410
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 6, 1, 7, 9 };
            List<int> listExample = new List<int>(input);
            listExample.Reverse();
            string result = string.Join(" ", listExample);
            Console.WriteLine(result);
        }
    }
}
