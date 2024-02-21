
//Console.Write("Enter your even Number:");
//int t = Convert.ToInt32(Console.ReadLine());
//Series num = new Series(t)
//    num.display();


//Console.Write("Enter your square number");
//int i = Convert.ToInt32(Console.ReadLine);
//for (int j = i; j < i;j=j+i)
//     {
//            Console.WriteLine(1 + j * 3 + " ");
//    }



//int start = 3;
//int end = 7;
//for (int i = start; i < end; i++)
//{
//    Console.WriteLine(i);
//}


using account;
using System.Security.Principal;
Account heikkisAccount = new Account("Heikki's account", 100.00);
Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

Console.WriteLine("Intial state");
Console.WriteLine(heikkisAccount);
Console.WriteLine(heikkisSwissAccount);

heikkisAccount.Widthraw(20);
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance);
heikkisSwissAccount.Deposit(200);
Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.balance);

Console.WriteLine("End state");
Console.WriteLine(heikkisAccount);
Console.WriteLine(heikkisSwissAccount);
