Console.WriteLine("Enter a three-digit number:");
int n = Convert.ToInt32(Console.ReadLine());
if(n>99)
    {
        Console.WriteLine(n.ToString()[2]);
    }
    else
    {
        Console.WriteLine("no third digit");
    }