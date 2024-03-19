class Lion : IAnimal
{
    public int Age { get; set; }
    public string Species { get; set; }
    public string ManeColour { get; set; }

    public void RequestUniqueCharacteristic()
    {
        Console.Write("What colour is its mane? ");
        ManeColour = Console.ReadLine();
    }

    public string GetDescription()
    {
        return $"a {Age}-year-old lion with a {ManeColour} mane";
    }
}
