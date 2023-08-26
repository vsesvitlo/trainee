static void Main(string[] args)
{
    int[] mass = { 1, 5, 0, 2 };

    int max = mass[0];

    for (int i = 1; i < mass.Length; i++)
    {
        if (mass[i] > max)
        {
            max = mass[i];
        }
    }


}
int counter = 0;
while (true)
{
    if (counter % 4 == 0)
        Console.WriteLine("H {0}", counter);
    if (counter % 7 == 0)
        Console.WriteLine("H {0}", counter);

    counter++;
    Thread.Sleep(1000);

}
/*
int num = 5;
int[] mass = new int[] { 2, 5 };

char ch = 'A';
char ch1 = 'B';
char[] chars_mass = new char[] { 'A', 'B', 'C' };
string chars = "ABC";

Console.WriteLine(ch);
Console.WriteLine(ch1);
Console.WriteLine();
Console.WriteLine((char)(ch + 4));
Console.WriteLine(ch1 + 0);*/