using Oefening_Circustrein;

namespace Tests;

[TestClass]
public class Scenarios
{
    public int TestTrain(int smallHerbivore, int mediumHerbivore, int largeHerbivore, int smallCarnivore, int mediumCarnivore, int largeCarnivore )
    {
        List<Animal> animals = new List<Animal>();

        // Add herbivores
        animals.AddRange(Enumerable.Repeat(new Herbivore(Animal.Sizes.Small), smallHerbivore));
        animals.AddRange(Enumerable.Repeat(new Herbivore(Animal.Sizes.Medium), mediumHerbivore));
        animals.AddRange(Enumerable.Repeat(new Herbivore(Animal.Sizes.Large), largeHerbivore));

        // Add carnivores
        animals.AddRange(Enumerable.Repeat(new Carnivore(Animal.Sizes.Small), smallCarnivore));
        animals.AddRange(Enumerable.Repeat(new Carnivore(Animal.Sizes.Medium), mediumCarnivore));
        animals.AddRange(Enumerable.Repeat(new Carnivore(Animal.Sizes.Large), largeCarnivore));

        Train train = new Train(animals);

        return train.Wagons.Count();
    }
    
    [TestMethod]
    public void Scenario1()
    {
        int expectedWagons = 2;
        int actualWagons = TestTrain(0, 3, 2, 1, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario2()
    {
        int expectedWagons = 2;
        int actualWagons = TestTrain(5, 2, 1, 1, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario3()
    {
        int expectedWagons = 4;
        int actualWagons = TestTrain(1, 1, 1, 1, 1, 1);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario4()
    {
        int expectedWagons = 5;
        int actualWagons = TestTrain(1, 5, 1, 1, 1, 2);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario5()
    {
        int expectedWagons = 2;
        int actualWagons = TestTrain(1, 1, 2, 1, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario6()
    {
        int expectedWagons = 3;
        int actualWagons = TestTrain(0, 2, 3, 3, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario7()
    {
        int expectedWagons = 13;
        int actualWagons = TestTrain(0, 5, 6, 7, 3, 3);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario8()
    {
        int expectedWagons = 2;
        int actualWagons = TestTrain(5, 3, 1, 0, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario9()
    {
        int expectedWagons = 6;
        int actualWagons = TestTrain(0, 0, 3, 1, 3, 2);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario10()
    {
        int expectedWagons = 8;
        int actualWagons = TestTrain(5, 5, 5, 2, 2, 2);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario11()
    {
        int expectedWagons = 2;
        int actualWagons = TestTrain(1, 3, 2, 0, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario12()
    {
        int expectedWagons = 2;
        int actualWagons = TestTrain(0, 3, 2, 1, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario13()
    {
        int expectedWagons = 2;
        int actualWagons = TestTrain(0, 2, 2, 2, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
    
    [TestMethod]
    public void Scenario14()
    {
        int expectedWagons = 3;
        int actualWagons = TestTrain(0, 6, 2, 2, 0, 0);
        
        Assert.AreEqual(expectedWagons, actualWagons);
    }
}