/*Завдання 3: Замовлення та клієнти Створіть клас Order, 
 * який містить властивості для номера замовлення, 
 * списку продуктів та загальної вартості. 
 * Створіть клас Customer, який містить ім'я клієнта, адресу та список замовлень. 
 * Реалізуйте методи для додавання замовлення клієнту та підрахунку загальної вартості всіх замовлень.*/
using System.Collections.Generic;

namespace _23._10._2024___6
{
    public class Product
    {
        public string name;
        public double price;
        public int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
    
    public class Order
    {
        public int numb;
        public Product[] list;
        public double price;

        public Order(int numb, Product[] list, double price)
        {
            this.numb = numb;
            this.list = list;
            this.price = price;
        }
        public double Quantity() {
            double result = 0;
            for (int i = 0; i < list.Length; i++)
            {
              result = list[i].quantity;
            }
            return result;
        }
        public void AddOrder(Order order) {
            int newNumb = order.numb + 1;

        }
    }
    public class Customer
    {
        public string name;
        public string address;
        public Order[] order;
        public int quant;

        public Customer(string name, string address, Order[] order, int quant)
        {
            this.name = name;
            this.address = address;
            this.order = order;
            this.quant = quant;
        }
        /*  public double Quantity()
          {
              double result = 0;
              for (int i = 0; i < order.Length; i++)
              {
                  result = order[i].quantity;
              }
              return result;
          }*/
        public void AddOrder(Product product)
        {

            int result = ;

            for (int i = 0; i < result; i++)
            {
                Order[] newOrder = new Order[result];


                result = order[i].numb + 1;
            }
           
        }
        public double TotalPrice()
        {
            double sum = 0;
            double result = Convert.ToDouble(quant);
            
            for (int i = 0; i < order.Length; i++)
            {
                sum += (order[i].price * result);
            }

            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product first = new Product("bread", 33, 2);
            Product second = new Product("butter", 64, 1);
            Product third = new Product("milk", 35, 3);
            Product[] list = { first, second };
            Order cart = new Order(0001, list, 2);

            //Customer customer = new Customer("Josh", "Lizard 12TH", 2);//?
        }
    }
}
