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
        public void AddProducts(Product product)
        {
            int newLength = list.Length + 1;
            Product[] newList = new Product[newLength];

             for(int i = 0; i < newLength - 1; i++)
            {
                newList[i] = list[i];
            }
            newList[newLength - 1] = product;
            list = newList;
        }
        public void RemoveProducts(Product product)
        {
            int calc = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].name == product.name)
                {
                    calc++;
                }
            }

            int newLength = list.Length - calc;
           if (calc == 0)
            {
                return;
            }

            Product[] newList = new Product[newLength];

            for (int i = 0, j = 0;  i < list.Length && j < list.Length; j++)
            {
               
                if (product.name != list[j].name)
                {
                    newList[i] = list[j];
                    i++;

                }
             
            }
           
            list = newList;

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
            cart.AddProducts(first);
            cart.AddProducts(second);
            cart.AddProducts(third);
            cart.RemoveProducts(first);
          
            Console.WriteLine(cart.Calc());
            Console.WriteLine(cart.TotalPrice());
        }
    }
}
