// x ++ --
// y ++ --

// ++x --y weight ++
// --x ++y weight --
// ++x ++y ++
//--x --y --


Console.WriteLine("Please, enter 1 - if you eat a lot, 2 - if you eat a few");
int amountFood = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter 1 - if you do exercises a lot, 2 - if you do exercises a few");
int amountTrainee = int.Parse(Console.ReadLine());

if (amountFood == 1 && amountTrainee == 1)
{
    Console.Write("You are in good shape");
}

if (amountFood == 2 && amountTrainee == 1)
{
    Console.Write("You are loosing a weight");
}

if (amountFood == 2 && amountTrainee == 2)
{
    Console.Write("You need to care about yourself");
}

if (amountFood == 1 && amountTrainee == 2)
{
    Console.Write("You need to go for sports");
}