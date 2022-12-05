class While{
    public void LearnWhile()
    {
         // using while show Hello Nepal when "y" is pressed
        string? key = "y";
        Console.WriteLine ("Press y to print it again or any other key to exit");
    while (key == "y")
    {
        Console.WriteLine ("******Hello While!********");

        key = Console.ReadLine();
    }
    }
}
