﻿namespace _18._12._2024___exclamation_marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "!!???????!!!!!";
          int result  = Kata.Product(s);
        Console.WriteLine(result);
          
        }
    }

public class Kata
    {
        public static int Product(string str)
        {

            int e = 0;
            int q = 0;
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 33)
                {
                    e++;
                }
                else if (str[i] == 63)
                {
                    q++;
                }

                result = e * q;
            }

            return result;
        }
    }
}
