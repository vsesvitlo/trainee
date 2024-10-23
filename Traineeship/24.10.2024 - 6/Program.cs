/*Завдання 2: Продукти та кошик Створіть клас Product,
 * який має властивості назва продукту, ціна та кількість.
 * Створіть клас ShoppingCart, що містить список продуктів. 
 * Реалізуйте методи для додавання продуктів до кошика, 
 * видалення продукту та обчислення загальної вартості кошика.*/
using System.Text.RegularExpressions;

namespace _24._10._2024___6
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
    public class ShoppingCart
    {
        Product[] list;

        public ShoppingCart(Product[] list)
        {
            this.list = list;
        }
        public int AddProducts( Product product)
        {
            return list.Length + 1; ///?
        }
        public int RemoveProducts(Product product)
        {
            return list.Length - 1; ///?
        }

        public int Calc()
        {
            return list.Length;
        }

        public double TotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += (list[i].price * list[i].quantity);
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
            ShoppingCart cart = new ShoppingCart(list);
            Console.WriteLine(cart.AddProducts(first));//??
            Console.WriteLine(cart.AddProducts(second));
            Console.WriteLine(cart.AddProducts(third));
            Console.WriteLine(cart.RemoveProducts(first));
            Console.WriteLine(cart.Calc());
            Console.WriteLine(cart.TotalPrice());
        }
    }
}
