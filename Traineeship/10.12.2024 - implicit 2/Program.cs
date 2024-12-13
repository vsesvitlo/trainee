/*Задача 2: Implicit Перетворення (комплексні числа, це схоже 
 * до реальних чисел але в них є два компоненти - звичайна частина і уявна частина)
Створіть клас ComplexNumber, що містить два числа: реальну 
та уявну частини. Додайте неявне перетворення з ComplexNumber до типу string,
де значення буде виведено як реальна частина + уявна частина i.*/
namespace _10._12._2024___implicit_2
{
    public class ComplexNumber
    {
       public int a;
       public int i;

        public ComplexNumber(int a, int i)
        {
            this.a = a;
            this.i = i;
        }
        public static implicit operator string(ComplexNumber complexNumber)
        {
            string result = complexNumber.a.ToString() + complexNumber.i;
            return result;
        }
        public static implicit operator double(ComplexNumber complexNumber)
        {
           double result = complexNumber.a + complexNumber.i;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber complexNumber = new ComplexNumber( 4, 9);
            Console.WriteLine(complexNumber.a.GetType());
            Console.WriteLine(complexNumber + "b");
        }
    }
}
