/*Count how often sign changes in array.

result
number from 0 to ... . Empty array returns 0

example
const arr = [1, -3, -4, 0, 5];


| elem | count |
|------|-------|
|  1   |  0    |
| -3   |  1    |
| -4   |  1    |
|  0   |  2    |
|  5   |  2    |


catchSignChange(arr) == 2; */
namespace _07._12._2024___plus_minus_plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, -3, 5 };
            int[] arr2 = { -1, 2, -9, 0 };
            // int[] num1 = { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2 };
            int result = Kata.CatchSignChange(arr2);
            Console.WriteLine(result);

        }
        public class Kata
        {
            public static int CatchSignChange(int[] arr)
            {
                int result = 0;
                if (arr.Length == 0)
                {
                    return 0;
                }
                for (int i = 0, j = 1; j < arr.Length; i++, j++)
                {
                    if ((arr[i] >= 0 && arr[j] < 0) || (arr[i] < 0 && arr[j] >= 0))
                    {
                        result++;
                    }
                }
                return result;
            }
        }
    }
}
