// See https://aka.ms/new-console-template for more information
/*105 Користувач вводить дві різних англійські літери в окремих рядках.
    Напишіть програму, яка виводить повідомлення про місце розташування
однієї літери відносно іншої у алфавіті.*/
//z
//a
//z is not less than a
Console.WriteLine("Please enter the letter");
string step1 = Console.ReadLine();
Console.WriteLine("Please enter the letter");
string step2 = Console.ReadLine();

var a = "";

        
        if (step1[0] > step2[0])
        {
            a = step1 + " is not less than " + step2;
        }
       else if (step1[0] == step2[0])
        {
            a = "They equal!";
        }
        else
        {
            a = step1 + " is less than " + step2;
        }

Console.WriteLine(a);

