namespace Oefening_Circustrein
{
    internal abstract class Animal
    {
        public enum Sizes
        {
            Small = 1,
            Medium = 3,
            Large = 5
        }

        public string Name { get; protected set; }
        public Sizes Size { get; private set; }

        protected Animal(Sizes size)
        {
            Size = size;
        }

        public abstract bool CanAddToWagon(Wagon wagon);
    }

    internal class Carnivore : Animal
    {
        public Carnivore(Sizes size) : base(size)
        {
            Name = "Carnivore";
        }

        public override bool CanAddToWagon(Wagon wagon)
        {
            return !wagon.StoredAnimals.Any(storedAnimal =>
                storedAnimal.Size >= Size);
        }
    }

    internal class Herbivore : Animal
    {
        public Herbivore(Sizes size) : base(size)
        {
            Name = "Herbivore";
        }

        public override bool CanAddToWagon(Wagon wagon)
        {
            return !wagon.StoredAnimals
                .Where(a => a is Carnivore)
                .Any(a => a.Size >= Size);
        }
    }
}