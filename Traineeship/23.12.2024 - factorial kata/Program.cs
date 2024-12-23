namespace _23._12._2024___factorial_kata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong result = Kata.Factorial(13); //6227020800
            Console.WriteLine(result);
        }
    }

        public  class Kata
        {
            public static ulong Factorial(ulong n)
            {

           ulong result = 1;
            //int h = 1;
            if (n == 0)
            {
                result = 1;
            }
            else
            {
                
                while (n >= 1)
                {
                    result *= n;
                    n--;
                }
            }

            ulong resultU = Convert.ToUInt64(result);
            return resultU;


            /*  int result = 0;
              int resultNew = 0;
              while (n >= 0)
              {
                  result *= n;
                  n--;

              }
              resultNew = result;*/
            //ulong resultU = Convert.ToUInt64(result);
            return resultU;
            }
        }
    }
