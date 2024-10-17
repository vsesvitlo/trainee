namespace _15._10._2024___1
{
    public class Book
    {
        public string title;
        public string author;
        public int quantityPages;
        public int yearPublicier;

        public Book(string title, string author, int quantityPages, int yearPublicier)
        {
            this.title = title;
            this.author = author;
            this.quantityPages = quantityPages;
            this.yearPublicier = yearPublicier;
        }
    }


    public class Library
    {
        Book[] library1;
        //list
        //dict

        public Library(Book[] library1)
        {
            this.library1 = library1;
        }

        public int Calc() { 
            return library1.Length;
        }

        public int CalcPages() {
            int n = 0;
            for (int i = 0; i < library1.Length; i++){
                n += library1[i].quantityPages;
            }
            return n;
        }
        public Book PopBook(string name) {
            for (int i = 0; i < library1.Length; i++)
            {
                if (name == )
                { }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Book A = new Book( "ABC", "authorABC", 100, 2020);
            Book B = new Book("BCD", "authorABC", 10, 2023);
            Book C = new Book("C", "authorABC", 190, 2021);
            Book D = new Book("D", "authorABC", 80, 2024);
            Book E = new Book("E", "authorABC", 20, 2020);
            Book[] shelf = { A, B, B, D, E };
            //Book[] shelf = new Book[] { A, B, C, D, E };
            Library first = new Library(shelf);
            Console.WriteLine(first.Calc());
            Console.WriteLine(first.CalcPages());

            Book F = new Book("ABC", "authorABC", 100, 2020);
            Book G = new Book("BCD", "authorABC", 10, 2023);
            Book K = new Book("C", "authorABC", 190, 2021);
            Book L = new Book("D", "authorABC", 80, 2024);
            Book M = new Book("E", "authorABC", 20, 2020);
            Book[] shelf2 = {F, G, K, L, M};
            Library second = new Library(shelf2);
        }
    }
}
