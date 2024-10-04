/*
213. Напишіть програму для побудови шаблону як у вихідних даних за введеним значенням n.

Вхідні дані:

5
Вихідні дані:

##
# #
#  #
#   #
#    #
*/

Console.WriteLine("Please, enter the n");
string step1 = Console.ReadLine();
int n = int.Parse(step1);
string empt = "0";
string filled = "#";
string result = "#";
int m = 1;
int x = 1;

while (m <= n && x <= n)
{
    x++;

    if (x != n)
    {
        result += empt;
     
    }else if ( x==n)
    {
        result += filled;
    }

  
    m++;
    //result += filled.Substring(0, 1);

    //Console.WriteLine(result);
    Console.WriteLine(result);
  
  
}

//Console.WriteLine(result);

//if()
/*for (int j = n; j >=0 ; j--)
{
    //empt += filled;
   // result += empt 
        
     //   + filled.Substring(0, 1);

    //
    /*if (j == n)
    {
        
            
            if (i == n - 1)
            {
                result += filled;
            }
            result += empt;
        }

        //   result = result.Substring(1, i);
      

    */
//}*/


/*if (j == 1)
{
    result += empt;
}*/
//result += empt;

//}

