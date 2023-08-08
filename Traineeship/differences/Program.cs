//2.Користувач вводить своє імя, вік і середній дохі за місяць(нехай в доларах)
//Якщо вік< 18, а дохід = 0 то вивести щось по типу "доброго, дня молодим"
//Якщо вік < 18, а дохід > 0 то вивести щось по типу "ого, заробляєте в такому молодому віці"//
//Якщо вік >= 18, а дохід = 0 то вивести щось по типу "попіклуйтеся про свої доходи"
//Якщо вік >= 18, а дохід > 0 то вивести щось по типу "доброго дня платнику податків"
//Якщо імя = "Байден" то вивести щось по типу "Доброго дня США!"


Console.WriteLine("PLease, enter your name");
string name = Console.ReadLine();
Console.WriteLine("PLease, enter your age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("PLease, enter your average month earnings");

int wage = int.Parse(Console.ReadLine());
if (age < 18 && wage == 0)
{
    Console.WriteLine("Hello youngers");
}
else if (age < 18 && wage > 0)
{
    Console.WriteLine("Wow, you earn money in such young age");
}
else if (age >= 18 && wage == 0)
{
    Console.WriteLine("You had to think about your earnings");
}
//if(age >= 18 && wage > 0)
else
{
    Console.WriteLine("Hello, tax payers!");
}
if (name == "Baiden")
{
    Console.WriteLine("Hello, USA!");
}



