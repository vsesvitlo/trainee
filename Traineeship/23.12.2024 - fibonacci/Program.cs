namespace _23._12._2024___fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Fibonacci.Fib(5); 
            Console.WriteLine(result);
        }
    }
    public class Fibonacci
    {
        public static int Fib(int n)
        {
            int result = 0;
            int result1 = 1;


            for (int i = 1; i <= n; i++)
            {
                
                result1 = result1 + result;
                result = result1;
            }



            // result1 = result;
            return result;
        }
    }
}
