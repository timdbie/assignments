namespace Oefening_Circustrein
{
    internal class Train
    {
        private List<Animal> _animals;
        public IReadOnlyList<Animal> Animals
        {
            get { return _animals; }
        }

        private List<Wagon> _wagons;

        public IReadOnlyList<Wagon> Wagons
        {
            get { return _wagons; }
        }

        public Train(List<Animal> animals)
        {
            this._animals = animals;
            _wagons = new List<Wagon>();
            SortAndAllocateAnimals();
        }
        
        private List<Animal> GetSortedCarnivores()
        {
            return _animals
                .Where(a => a is Carnivore)
                .OrderByDescending(a => a.Size)
                .ToList();
        }

        private List<Animal> GetSortedHerbivores()
        {
            List<Animal> herbivorousAnimals = _animals
                .Where(a => a is Herbivore)
                .ToList();
            
            int largeHerbivoresCount = herbivorousAnimals.Count(a => a.Size == Animal.Sizes.Large);
            int mediumHerbivoresCount = herbivorousAnimals.Count(a => a.Size == Animal.Sizes.Medium);
            
            int carnivorousCount = _animals.Count(a => a is Carnivore);

            if (largeHerbivoresCount >= mediumHerbivoresCount || carnivorousCount == 0)
            {
                return herbivorousAnimals.OrderByDescending(a => a.Size).ToList();
            }
            else
            {
                return herbivorousAnimals.OrderBy(a => a.Size).ToList();
            }
        }

        private void SortAndAllocateAnimals()
        {
            List<Animal> carnivorousAnimals = GetSortedCarnivores();
            List<Animal> herbivorousAnimals = GetSortedHerbivores();

            StoreAnimals(carnivorousAnimals);
            StoreAnimals(herbivorousAnimals);
        }

        private void StoreAnimals(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                if (!Wagons.Any(wagon => wagon.TryAddAnimal(animal)))
                {
                    CreateWagon(animal);
                }
            }
        }

        private void CreateWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.TryAddAnimal(animal);
            _wagons.Add(wagon);
        }
    }
}
