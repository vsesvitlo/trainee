namespace _23._12._2024___fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Fibonacci.Fib(10); 
            Console.WriteLine(result);
        }
    }
    public class Fibonacci
    {
        public static int Fib(int n)
        {
            int result = 0;
            int result1 = 1;
            int m = 0;

            for (int i = 0; i <= n; i++)
            { 
                result = result + m;
                m = result1;
                result1= result;
            }



            // result1 = result;
            return result;
        }
    }
}
