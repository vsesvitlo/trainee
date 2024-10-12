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

        public Vector CutVector(Vector cutter)
        {
            Vector fourth = new Vector(this.x - cutter.x, this.y - cutter.y, this.z - cutter.z);
            return fourth;
        }

        public Vector MultiVector(Vector mult)
        {
            Vector fifth = new Vector(this.x * mult.x, this.y * mult.y, this.z * mult.z);
            return fifth;
        }

        public Vector SqVector()
        {

            /*double a = Convert.ToDouble(this.x);
            double b = Convert.ToDouble(this.y);
            double c = Convert.ToDouble(this.z);*/
            Vector sixth = new Vector((this.x * this.x), this.y * this.y , this.z * this.z);
            return sixth;
        }


        public override string? ToString()
        {
            return this.x.ToString() + " " + this.y.ToString() + " "+ this.z.ToString();
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

            Vector fourth = first.CutVector(second);
            Console.WriteLine(fourth);

            Vector fifth = first.MultiVector(second);
            Console.WriteLine(fifth);

            Vector sixth = first.SqVector();
            Console.WriteLine(sixth);

            Vector seventh = second.SqVector();
            Console.WriteLine(seventh);


            /* Console.WriteLine(third.x);
             Console.WriteLine(third.y);
             Console.WriteLine(third.z);*/
        }
    }
}
