namespace _08._10._2024___1
{
    public class Human
    {
        string name;
        public int children;
        double money;

        public Human(string name, int children, double money)
        {
            this.name = name;
            this.children = children;
            this.money = money;
        }

        public string StatusChild() {
            if (children == 0)
            {
                return "No children";
            }
            else if (children <=2)
            {
                return "Usual family";
            }
            else if(children >= 3)
            {
                return "Large family";
            }
            else
            {
                return "Please, enter the number";
            }
        }
        
        public double RestsMoney(double priceAdult = 30, double priceChild = 15)
        {
            return money - priceAdult - priceChild * children;
        }


        public bool isCorrect(int numb)
        {
            if(children <= numb)
            {
                return true;
            }
            return false;
        }

        public int AllChildren(Human other)
        {
            return children + other.children;
        }

        public void TakeChildren(Human donor)
        {
            children += donor.children;
            donor.children = 0;
        }

    }
    public class Program
    {
       

        static void Main(string[] args)
        {
            Human example = new Human("Eva", 2, 100);
            Human example2 = new Human("Josh", 3, 120);


            Console.WriteLine(example.isCorrect(3));
            Console.WriteLine(example.StatusChild());
            Console.WriteLine(example.RestsMoney());
            Console.WriteLine(example.AllChildren(example2));
            example2.TakeChildren(example);
            Console.WriteLine(example.children);
            Console.WriteLine(example2.children);

        }
    }
}
