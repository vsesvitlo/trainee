// 0 --
// 0++ ++
//10++ --- ++


Console.WriteLine("How much sweets do you eat?");
int sweets = int.Parse(Console.ReadLine());
if (sweets == 0)
{
    Console.WriteLine("I am not happy");
}

else
{
    Console.WriteLine("I am happy");
    if (sweets >= 10)
    {
        Console.WriteLine("I have a rush");
    }

}