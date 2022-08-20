Console.WriteLine("Enter a three-digit number.\nTo exit the program, click Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("Second number: {1}",input, input[1]);
        else
            break;
    }