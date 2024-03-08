using Oefening_Circustrein;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of small herbivores:");
        int smallHerbivoresCount = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the number of medium herbivores:");
        int mediumHerbivoresCount = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the number of large herbivores:");
        int largeHerbivoresCount = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the number of small carnivores:");
        int smallCarnivoresCount = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the number of medium carnivores:");
        int mediumCarnivoresCount = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the number of large carnivores:");
        int largeCarnivoresCount = int.Parse(Console.ReadLine()!);

        List<Animal> animals = new List<Animal>();

        // Add herbivores
        animals.AddRange(Enumerable.Repeat(new Herbivore(Animal.Sizes.Small), smallHerbivoresCount));
        animals.AddRange(Enumerable.Repeat(new Herbivore(Animal.Sizes.Medium), mediumHerbivoresCount));
        animals.AddRange(Enumerable.Repeat(new Herbivore(Animal.Sizes.Large), largeHerbivoresCount));

        // Add carnivores
        animals.AddRange(Enumerable.Repeat(new Carnivore(Animal.Sizes.Small), smallCarnivoresCount));
        animals.AddRange(Enumerable.Repeat(new Carnivore(Animal.Sizes.Medium), mediumCarnivoresCount));
        animals.AddRange(Enumerable.Repeat(new Carnivore(Animal.Sizes.Large), largeCarnivoresCount));

        Train train = new Train(animals);

        Console.Clear();

        foreach (var wagon in train.Wagons) 
        {
            foreach (Animal animal in wagon.StoredAnimals)
            {
                Console.WriteLine($"{animal.Name} ({animal.Size})");
            }
            Console.WriteLine("------------");
            Console.WriteLine($"Space occupied: {wagon.Occupied}");
            Console.WriteLine("");
        }

        Console.WriteLine($"Total wagons: {train.Wagons.Count()}");
        Console.ReadLine();
    }
}
