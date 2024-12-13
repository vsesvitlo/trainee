/*Задача: 
є набір продуктів які хочеться купити 
{"Сік", "Вода", "Хліб", "Мясо", "Гриби"}

і є магазини із продуктами: 
{"Вода", "Хліб", "Молоко", "Морозиво"}
{"Цукор", "Сіль", "Паприка", "Перець"}
{"Вафлі", "Бублик", "Інжир", "Хліб"}

сказати "Yes" - якщо хоча б 1 продукт в магазині є із бажаного списку, 
інакше сказати "No"*/
namespace _12._12._2024___list
{

    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = { "Сік", "Вода", "Хліб", "Мясо", "Гриби" };
            List<string> products = new List<string>(input);
            string[] input1 = { "Вода", "Хліб", "Молоко", "Морозиво" };
            string[] input2 = { "Цукор", "Сіль", "Паприка", "Перець" };
            string[] input3 = { "Вафлі", "Бублик", "Інжир", "Хліб" };
            List<string> productsShop = new List<string>(input3);
            string positive = "Yes";
            string result = "No";
            for (int i = 0; i < products.Count; i++)
            {
                if (productsShop.Contains(products[i]) )
                {
                    result = positive;
                    break;
                }
            }
            Console.Write(result);
        }
    }
}
