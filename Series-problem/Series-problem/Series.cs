

//using System.Runtime.CompilerServices;

//namespace Series_problem;

//public struct Series
//{
//    public int n;
//    public int i; 

//    public Series(int i, int t)
//    {
//        this.n = n;
//        this.i = i;

//    }
//    public void display()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write(1 + i * 3 + " ");
//        }

//    }


//}


namespace account;
public class Account
{
    public string Name;
    public double Balance;
    public double Widthraw;
    public double Deposit;
    public Account(string name, double balance, double widthraw, double deposit)
    {
        Name = name;
        Balance = balance;
        Widthraw = widthraw;
        Deposit = deposit;
    }
    public void display()
    {
        Widthraw = Balance-Deposit;
        Balance = Widthraw;
        Console.WriteLine($"your name {Name} your balance {Balance} {Widthraw} {Deposit}");
    }
}