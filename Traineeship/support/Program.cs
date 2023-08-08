//Задача на допомогу від держави (було актуально рік назад). Всім переселенцям дається допомога. 
//Користувач вводить свій вік, чи він переселенець і статки (нехай в гривнях).

//Якщо вік в діапазоні 0 - 18 людині дається + 1.000грн
//Якщо вік від 60+ то людині дається +1.500 грн
//Якщо людина переселенець то їй дається +2.000 грн
//Якщо в людини статки до 5.000 грн то людині дається +3.000 (всім, дітям також)
//Якщо в людини статки від 5.000 до 10.000 то даємо +2.000 грн
//Якщо в людини статки від 10.000 до 20.000 то даємо +500 грн

//За введеною анкетою із трьох елементів (вік, чи переселенець, статки) вивести на екран загальну суму допомоги

Console.WriteLine("Please, enter your age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Did you migrate because of war? Yes - enter 1, no - enter 2");
int chooseForAdditionalHelp = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your earnings in grivna`s");
int earnings = int.Parse(Console.ReadLine());
int sumAge = 0;
int sumResult = 0;
int helpForMigrate = 2000;
int helpForMigrateUnder18 = 1000;
int helpForMigrateAbove60 = 1500;
int helpForMigrateUnder5000 = 3000;
int helpForMigrateUnder10000 = 2000;
int helpForMigrateUnder20000 = 500;

if (chooseForAdditionalHelp == 1)
{
    if (age < 18)
    {
        sumAge = earnings + helpForMigrate + helpForMigrateUnder18;
        Console.WriteLine(sumAge);
    }
    else if (age >= 60)
    {
        sumAge = earnings + helpForMigrate + helpForMigrateAbove60;
        Console.WriteLine(sumAge);
    }

    if (earnings < 5000)
    {
        sumResult = sumAge + helpForMigrateUnder5000;
        Console.WriteLine(sumResult);
    }
    else if (earnings < 10000 && earnings >= 5000)
    {
        sumResult = sumAge + helpForMigrateUnder10000;
        Console.WriteLine(sumResult);
    }
    else if (earnings < 20000 && earnings >= 10000)
    {
        sumResult = sumAge + helpForMigrateUnder20000;
        Console.WriteLine(sumResult);
    }
    Console.WriteLine($"You will get {sumResult}");
};
if (chooseForAdditionalHelp == 2)
{
    Console.WriteLine($"You will get only your earnings {earnings}");
}