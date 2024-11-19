/*Написати програму, яка приймає на вхід послідовність з цілих чисел, 
 * після чого друкує значення всіх її елементів, піднесені до квадрату.

Вхідні дані:

1 2 3 4 5 6 7 8 9
Вихідні дані:

1 4 9 16 25 36 49 64 81*/
namespace _19._11._2024___453
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> listExample = new List<int>(input);

            List<int> listExampleNew = new List<int>();

            for (int i = 0; i < input.Length; i++) {
                 /*double a = Convert.ToDouble(input[i]);
                 double b = Math.Pow(a, a);
                 string d = Convert.ToString(b);
                 int c = int.Parse(d);*/
               listExampleNew.Add(input[i] * input[i]);
            }
            string result1 = string.Join(" ", listExampleNew);
            Console.WriteLine(result1);
        }
    }
}
