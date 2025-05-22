for (int i = 1; i < 20; i++)
{
    Console.Write("- " + "June ");
    if (i == 1 || i == 31)
    {
        Console.WriteLine(i + "st" + ": ...");
    }
    else if (i == 2 || i == 22)
    {
        Console.WriteLine(i + "nd" + ": ...");
    }
    else if (i == 3 || i == 23)
    {
        Console.WriteLine(i + "rd" + ": ...");
    }
    else
    {
        Console.WriteLine(i + "th" + ": ...");
    }
}