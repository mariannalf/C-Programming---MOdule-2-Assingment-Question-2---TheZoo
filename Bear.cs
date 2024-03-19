class Bear : IAnimal
{
    public int Age { get; set; }
    public string Species { get; set; }
    public bool IsGrizzly { get; set; }

    public void RequestUniqueCharacteristic()
    {
        Console.Write("Is it a grizzly bear (true/false)? ");
        string userInput = Console.ReadLine().ToLower(); // Convert input to lowercase for case-insensitive comparison
        if (userInput == "true")
        {
            IsGrizzly = true;
        }
        else if (userInput == "false")
        {
            IsGrizzly = false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            // Prompt the user again until they provide valid input
            RequestUniqueCharacteristic();
        }
    }

    public string GetDescription()
    {
        string bearType = IsGrizzly ? "grizzly" : "non-grizzly";
        return $"a {Age}-year-old {bearType} bear";
    }
}
