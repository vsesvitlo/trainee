namespace _11._10._2024___1
{
    public class Vector
    {
        public int x;
        public int y;
        public int z;

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }



        public Vector AddVector(Vector adder)
        {
            Vector third = new Vector(this.x + adder.x, this.y + adder.y, this.z + adder.z);
            return third;
        }

        public override string? ToString()
        {
            return this.x.ToString() + this.y.ToString() + this.z.ToString();
        }
    }



    internal class Program
    {


        static void Main(string[] args)
        {
            Vector first = new Vector(1, 2, 3);
            Vector second = new Vector(4, 5, 6);

            Vector third = first.AddVector(second);
            Console.WriteLine(third);
           /* Console.WriteLine(third.x);
            Console.WriteLine(third.y);
            Console.WriteLine(third.z);*/
        }
    }
}
