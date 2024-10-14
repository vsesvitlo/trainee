/*Напишіть клас Coin, який описує монету, яку можна підкидати. 
 * При створенні екземпляру класу, екземпляр отримує атрибут
 * __sideup зі значенням heads або tails. У класі визначте метод toss, 
 * який випадково визначає результат підкидання монети - орел чи решка.
 * Створіть екземпляр класу і виведіть на екран n підкидань монети.*/namespace _14._10._2024___816
{
    public class Coin
    {
        public string [] __sideup;

        public Coin(string [] __sideup)
        {
            this.__sideup = __sideup;
           /* __sideup = "heads";
            __sideup = "tails";*/
        }
        public int TossNumber()
        {
           var rand = new Random();
           int n = rand.Next(1, 10);
            return n;
        }
        public string Toss()
        {
            Random rnd = new();
            string[] sideup = [ "heads", "tails"];
            int mIndex = rnd.Next(sideup.Length);
            return sideup[mIndex];
        }
        

    }
        public class Program
    {
        static void Main(string[] args)
        {
           Coin creation = new Coin(["heads", "tails"]);
            //var rand = new Random();
            //int n = rand.Next(1, 5);

            for (int i = 1; i <= creation.TossNumber(); i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(creation.Toss());
            }
          
        }
    }
}
