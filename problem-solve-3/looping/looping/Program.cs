//int i = 1;  // looping start
//while (i<=10) // loop end 
//{
//    Console.WriteLine($"{i} Cute ar dibba");
//    i+=2; // step
//    // i = i+2;

//}

// 3 x 1 = 3
int x = int.Parse(Console.ReadLine());
for(int a = 1; a <= x;a++)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{a} X {i} = {a * i} ");
    }
    Console.WriteLine();
}
Console.ReadKey();