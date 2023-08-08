Console.WriteLine("Please, enter is temperature outside more or less 20 centigrates? 1 - more, 2 - less");
int temperature = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter is it raining outside or not? 1 - yes, 2 - no");
int rainOrNot = int.Parse(Console.ReadLine());
if (temperature == 1)
{
    Console.WriteLine("I am going outside");
}

else
{
    Console.WriteLine("I am staying home");
};
if (rainOrNot == 1)
{
    Console.WriteLine("My Knees are ill");
}
else
{
    Console.WriteLine("I am Ok");
}