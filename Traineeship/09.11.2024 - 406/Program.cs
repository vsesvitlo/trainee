/*Створіть список на основі введеної послідовності цілих чисел і 
 * надрукуйте його елементи таким чином: два останні елементи переміщені
 * з кінця в початок списку без зміни їх початкового порядку.

Вхідні дані:

4 10 2 9 4 7 3
Вихідні дані:

7 3 4 10 2 9 4*/
using System.Linq;

namespace _09._11._2024___406
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 4, 10, 2, 9, 4, 7, 3 };
            List<int> listExample = new List<int>(input);
            int count = listExample.Count;
            
            List<int> listExample2 = new List<int> (listExample.Slice(0, count - 2));
            List<int> listExample3 = new List<int>(listExample.Slice(count - 2, 2));
            foreach (int i in listExample2)
            {
                listExample3.Add(i);
            }
           foreach (int i in listExample3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
