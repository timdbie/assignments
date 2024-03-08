namespace Oefening_Circustrein
{
    internal class Wagon
    {
        public int Capacity { get; private set; }
        public int Occupied { get; private set; }
        
        private List<Animal> _storedAnimals;
        public IReadOnlyList<Animal> StoredAnimals
        {
            get { return _storedAnimals; }
        }

        private const int WagonCapacity = 10;

        public Wagon()
        {
            Capacity = WagonCapacity;
            Occupied = 0;
            _storedAnimals = new List<Animal>();
        }

        public bool TryAddAnimal(Animal animal)
        {
            if (Occupied + (int)animal.Size <= Capacity)
            {
                if (animal.CanAddToWagon(this))
                {
                    _storedAnimals.Add(animal);
                    Occupied += (int)animal.Size;
                    return true;
                }
            }
            return false;
        }
    }
}
