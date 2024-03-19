class Wolf : IAnimal
{
    public int Age { get; set; }
    public string Species { get; set; }
    public int Speed { get; set; }

    public void RequestUniqueCharacteristic()
    {
        Console.Write("How fast can it run (in km/h)? ");
        Speed = int.Parse(Console.ReadLine());
    }

    public string GetDescription()
    {
        return $"a {Age}-year-old wolf that runs {Speed} km/h";
    }
}
