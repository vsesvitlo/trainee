namespace _15._11._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object animal = ("dog");
            Console.WriteLine((animal.GetType()));
            Console.WriteLine(animal is String);
            Console.WriteLine(animal is Object);
            Console.WriteLine(animal.GetType() == typeof(Object));
            Console.WriteLine(animal.GetType() == typeof(String));

            object[] arr1 = new object[3];
            arr1[0] = "one";
            arr1[1] = 2;
            arr1[2] = 3.33;
            Console.WriteLine(arr1[0].GetType());
            int b = 0;
            b = (int)arr1[0];
            if (arr1[1] is int)
            {
              b = (int) arr1[1] + 55;
            }
            
        }
    }
}
