using System.Collections;

namespace _29._11_._2024___array__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 =  { 8, 9, 9, 9};
            int[] newNum1 = { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2 };
            int [] num2 = Kata.UpArray(num1);
            int[] newNum2 = Kata.UpArray(newNum1);
            for (int k = 0; k < num2.Length; k++)
            {
                Console.WriteLine((num2[k]));
            }
            for (int k = 0; k < newNum2.Length; k++)
            {
                //Console.WriteLine((newNum2[k]));
            }
        }
    }
    public static class Kata
    {
        public static int[] UpArray(int[] num)
        {
            /*string a = "";
            string element = "";
            int sum = 0;
            int[] newNum = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                if ((num[i] >= 0) && (num[i] < 10))
                {
                    a += num[i];
                }
               newNum =  null;
            }
            int.TryParse(a, out int sumConvert);
            sum = sumConvert + 1;
            string sumForReverse = sum.ToString();

            for (int j = 0; j < sumForReverse.Length; j++)
            {
                element = sumForReverse[j].ToString();
                newNum[j] = int.Parse(element);

            }

            */
            int[] newNum = new int[num.Length];
            int z = 0;
            if (num.Length == 0)
            {
                return null;
            }
            int result = num.Count(k => k == 9);
            if (result == num.Length)
            {
                newNum = new int[num.Length + 1];
                newNum[0] = 1;
                return newNum;
            }
            for (int i = num.Length - 1; i > 0; i--) //? 72 - 
            {

                if ( num[i] < 0 || num[i] > 9)
                {
                    return null;
                }
                if (num[i] == 9)
                    {
                        newNum[i] = 0;
                        z = num[i - 1] + 1;
                        newNum[i - 1] = z;
                    if (newNum[0] == z )
                        break;
                    }

                else {
                    newNum[i] = num[i];
                    newNum[newNum.Length - 1] = num[num.Length - 1] + 1;
                }
                
                
            }
            return newNum;
        }
    }
}
