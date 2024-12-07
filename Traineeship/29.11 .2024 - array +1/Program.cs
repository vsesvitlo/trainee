using System.Collections;

namespace _29._11_._2024___array__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] num1 =  { 2, 3, 5};
           // int[] num1 = { 1, 2, 9};
           // int[] num1 = { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2 };
            int [] num2 = Kata.UpArray(num1);
            //int[] newNum2 = Kata.UpArray(newNum1);
            for (int k = 0; k < num2.Length; k++)
            {
                Console.WriteLine((num2[k]));
            }
            //for (int k = 0; k < newNum2.Length; k++)
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
            num.CopyTo(newNum, 0);
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
            for (int i = newNum.Length - 1; i > 0; i--)
            {
                if (newNum[i] < 0 || newNum[i] > 9)
                {
                    return null;
                }
                if (newNum[newNum.Length - 1] == 9)
                {
                    newNum[newNum.Length - 1] = 0;
                    z = newNum[newNum.Length - 2] + 1;
                    newNum[newNum.Length - 2] = z;
                    if (newNum[0] == z)
                    {
                        break;
                    }
                    if (newNum[newNum.Length - 2] > 9)
                    {
                        newNum[newNum.Length - 2] = 0;
                        newNum[newNum.Length - 3] += 1;
                    }
                    if (newNum[0] == z)
                    {
                        break;
                    }
                    if (newNum[newNum.Length - 3] > 9)
                    {
                        newNum[newNum.Length - 3] = 0;
                        newNum[newNum.Length - 4] += 1;
                    }
                    if (newNum[0] == z)
                    {
                        break;
                    }

                    break;
                }

                newNum[newNum.Length - 1] += 1;
                break;



            }
            /*for (int i = newNum.Length - 1; i > 0; i--)
           {
               if (newNum[i] < 0 || newNum[i] > 9)
               {
                   return null;
               }
               if (newNum[newNum.Length - 1] == 9)
               {
                   newNum[newNum.Length - 1] = 0;
                   z = newNum[newNum.Length - 2] + 1;
                   newNum[newNum.Length - 2] = z;
                   if (newNum[0] == z)
                   {
                       break;
                   }
                  // newNum[newNum.Length - 1] += 1;
                   break;
               }
               newNum[newNum.Length - 1] += 1;
               break;

           }
           {
               //newNum[0] = num[0];

               if (num[i] < 0 || num[i] > 9)
               {
                   return null;
               }
               if (num[i] == 9)
               {
                   newNum[i] = 0;
                   z = num[i - 1] + 1;
                   newNum[i - 1] = z;
                   if (newNum[0] == z)
                   {
                       break;
                   }
                   newNum[0] = num[0];
                   break;
               }

               else
               {
                   newNum[0] = num[0];
                   newNum[i] = num[i];
                   newNum[newNum.Length - 1] = num[num.Length - 1] + 1;
               }

           }*/
            return newNum;
            
        }
    }
}
