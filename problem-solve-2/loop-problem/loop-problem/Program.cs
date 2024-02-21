//////////print even number////
//using System.Diagnostics.CodeAnalysis;

//Console.Write("Enter the even number: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = 2; i <= n; i = i + 2)
//{
//    Console.Write(i + " ");

//}
//Console.WriteLine("\n/*--------------------*/");
//Console.WriteLine("\n");

////////sum of even number////
//Console.Write("Enter the number: ");
//int m = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 0; i < m; i++)
//{
//    Console.Write(i + " ");
//    sum = sum + i;
//}
//Console.WriteLine("\n");
//Console.WriteLine("\n Sum of all even number=" + sum);
//Console.WriteLine("\n/*--------------------*/");

//Console.WriteLine("\n");


//////odd number////
//Console.Write("Enter the odd number: ");
//int k = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= k; i = i + 2)
//{
//    Console.Write(i + " ");

//}
//Console.WriteLine("\n/*--------------------*/");

//Console.WriteLine("\n");



////////factorial/////



//Console.Write("Enter the number:");
//int num = Convert.ToInt32(Console.ReadLine());
//int fact = 1;
//for (int i = 1; i <= num; i++)
//{
//    fact = fact * i;
//}
//Console.WriteLine("\n calculate factorial is:" + fact);
//Console.WriteLine("\n/*--------------------*/");

//Console.WriteLine("\n");



/////prime number logic-1/////
//Console.Write("Enter the prime number: ");
//int P = Convert.ToInt32(Console.ReadLine());
//for (int i = 2; i < P; i++)
//{
//    bool u = true;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            u = false;
//            break;
//        }
//    }
//    if (u)
//    {
//        Console.Write(i + " ");
//    }
//}
Console.Write("Enter the number: ");
int p=Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < p; i++)
{
    bool x = true;
    for (int j = 0; j < i; j++)
    {
        if (i % j == 0)
        {
            x= false;
            break;
        }
    }
    if (x)
    {
        Console.WriteLine(i + "");
    }
}


//Console.WriteLine("\n/*--------------------*/");

//Console.WriteLine("\n");

/////////swapping number//////
//Console.Write("Enter the 1st number:");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the 2nd number:");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = num1; num1 = num2; num2 = num3;
//Console.WriteLine($"\n swapping 1st number= {num1} \n swapping 2nd number= {num2}");

//Console.WriteLine("\n/*--------------------*/");

//Console.WriteLine("\n");

////////swapping two number without use 3rd variable////////
//Console.Write("Input number A: ");
//int A = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input number B: ");
//int B = Convert.ToInt32(Console.ReadLine());
//A = A + B;
//B = A - B;
//A = A - B;
//Console.WriteLine($"Swapping number A: {A} Swapping number B: {B}");

//Console.WriteLine("\n/*--------------------*/");

//Console.WriteLine("\n");


/////////Fibonacci/////
//Console.Write("Enter The fibonacci: ");
//int y = Convert.ToInt32(Console.ReadLine());
//int a = 0;
//int b = 1;
//int c = 0;
//for (int i = 1; i < y; i++)
//{
//    c = a + b;
//    Console.Write(c + ",");
//    a = b;
//    b = c;
//}
//Console.ReadKey(true);