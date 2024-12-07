/*I'm new to coding and now I want to get the sum of two arrays... 
 * Actually the sum of all their elements. I'll appreciate for your help.

P.S. Each array includes only integer numbers. Output is a number too.*/
namespace _07._12._2024___array_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 5 };
            int[] arr2 = { 1, 2, 9};
            // int[] num1 = { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2 };
            int result  = Kata.ArrayPlusArray(arr1,arr2);
            Console.WriteLine(result);
            //int[] newNum2 = Kata.UpArray(newNum1);
        }
        public static class Kata
        {
            public static int ArrayPlusArray(int[] arr1, int[] arr2)
            {
                int result1 = 0;
                int result2 = 0;
                int result3 = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    result1 += arr1[i];
                }
                for (int j = 0; j < arr2.Length; j++)
                {
                    result2 += arr2[j];
                }
                result3 = result1 + result2;
                return result3;
            }
        }
    }
}
