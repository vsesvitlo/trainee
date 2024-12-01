/*завдання на оператори: 
Перегрузити оператори "!=" i "==" для адресу(клас адреси має два поля - вулиця і номер будинку)
*/

namespace _01._12._2024___override
{
    public class Adress
    {
        public string adress;
        public int number;

        public Adress(string adress, int number)
        {
            this.adress = adress;
            this.number = number;
        }
        public virtual bool Checking(string adress2, int number2)
        {
            if (this.adress == adress2 && this.number == number2)
            {
                return true;
            }
            return false;
        }
    }
    public class CheckAdress : Adress
    {
        public CheckAdress() : base("Abc", 1)
        {
            Checking(this.adress, this.number);
        }
        public override bool Checking(string adress2, int number2)
        {
            if (this.adress != adress2 && this.number != number2)
            {
                return false;
            }
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Adress example = new Adress("Zizkova", 1121);
            CheckAdress example1 = new CheckAdress();
            CheckAdress example2 = new CheckAdress();

            Console.WriteLine(example1.Checking("Zizkova", 1121));
            Console.WriteLine(example2.Checking("Abc", 1));
        }
    }
}
