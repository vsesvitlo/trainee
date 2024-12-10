/*завдання на оператори: 
Перегрузити оператори "!=" i "==" для адресу(клас адреси має два поля - вулиця і номер будинку)
*/

using System.Net.Sockets;

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
        public virtual bool Equals(Adress adress)
        {
            if (this.adress == adress.adress && this.number == adress.number)
            {
                return true;
            }
            else {
                return false;
            } 
        }
    }
    public class CheckAdress : Adress
    {
        public CheckAdress() : base("Abc", 1)
        {
            Equals(this.adress, this.number);
        }

        public override bool Equals(Adress adress)
        {
            if (adress == null || !(adress is Adress) || (number == null) || !(number is Adress))
                return false;
            else
                return this.adress == ((Adress)adress).adress;
        }
        /*public override bool Checking(string adress2, int number2)
        {
            if (this.adress != adress2 || this.number != number2)
            {
                return true;
            }
            else {
                return false;

            }
            
        }*/

        /*public override bool Equals(Object obj)
   {
      if (obj == null || !(obj is Dog))
         return false;
      else
         return this.Breed == ((Dog) obj).Breed;
   }

   public override int GetHashCode()
   {
      return this.Breed.GetHashCode();
   }

   public override string ToString()
   {
      return this.Breed;
   }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Adress example = new Adress("Zizkova", 1121);
            CheckAdress example1 = new CheckAdress();
            CheckAdress example2 = new CheckAdress();

            Console.WriteLine(example1.Equals(example));
            
        }
    }
}
