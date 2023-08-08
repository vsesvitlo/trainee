Console.WriteLine("Please, enter your age");
string age = Console.ReadLine();

int converse = int.Parse(age);
if (converse >= 18)
{
    Console.WriteLine("Ok, you can do it");
}
else
{
    Console.WriteLine("Sorry, you can't do it");
}
