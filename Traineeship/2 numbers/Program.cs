Console.WriteLine("Please, enter 1-st number");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter 2-st number");
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber > 0 && secondNumber > 0)
{
    int sum = firstNumber + secondNumber;
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Please, enter correct number");
}
