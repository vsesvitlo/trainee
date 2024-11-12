/*Напишіть програму, яка роздруковує лише ті елементи введеного списку,
 * що менше введеного значення n. Список містить унікальні значення.

Вхідні дані:

2 7 11 3 8 90 144 15 5
94
Вихідні дані:

2 7 11 3 8 90 15 5*/

namespace _12._11._2024___412
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 7, 11, 3, 8, 90, 144, 15, 5};
            int k = 94;
            List<int> listExample = new List<int>(input);
            List<int> listExampleNew = new List<int>();
            for (int i = 0; i < input.Length; i++) {
                if (input[i]< k)
                {
                    listExampleNew.Add(input[i]);
                }
            }
            string result = string.Join(" ", listExampleNew);
            Console.WriteLine(result);
        }
    }
}
