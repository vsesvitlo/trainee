/*Напишіть клас Bank для опису простих операції з вашим банківським рахунком: 
 * покласти на рахунок, зняти з рахунку, переглянути рахунок. При створенні екземпляру класу, 
 * екземпляр отримує атрибут __balance з певним значенням. Клас повинен містити методи для додавання 
 * коштів на рахунок і знімання з рахунку, за умови, що на рахунку достатньо коштів.

Вхідні дані:

Немає
Вихідні дані:

I open a bank account +
I deposit to your account:
5000
On the account: 5000.00
I withdraw from your bank account:
4200
On the account: 800.00
I open a bank account
I deposit to your account:
1000
On the account: 1000.00
I withdraw from your bank account:
1200
Error: not enough money
On the account: 1000.00*/

namespace _08._10._2024_814
{
    public class Bank
    {
        double money;


        public Bank(double money)
        {
            this.money = money;
        }

        public string Greeting()
        {
            string greetings = "I have opened a bank account";
            return greetings;
        }
        public string Deposit(double sumToReceive)
        {
            /*Console.WriteLine("Please, enter the sum to deposit");
            string step1 = Console.ReadLine();
            double sumToReceive = double.Parse(step1);*/

            double result = money + sumToReceive;
            string information = "I have deposited to your account: " + sumToReceive +
            " " + "On the account: " + result;
            return information;
        }
        public string Credit(double sumToMinus)
        {
           /* Console.WriteLine("Please, enter the sum to withdrawn");
            string step2 = Console.ReadLine();
            double sumToMinus = double.Parse(step2);*/
            string information = "";

            if (money < sumToMinus)
            {
                information = "Error: not enough money." + " " +
                    "On the account: " + money;
            }
            else
            {
                double result = money - sumToMinus;
                information = "I have withdrawn from your account: " + sumToMinus + " " +
                "On the account: " + result;
            }
            return information;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1000);
            Console.WriteLine(bank.Greeting());
            Console.WriteLine(bank.Deposit(100));
            Console.WriteLine(bank.Credit(40));
            
        }
    }
}
