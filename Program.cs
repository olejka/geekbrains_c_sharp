Console.WriteLine("Number a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number b:");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.WriteLine("max = " + max);