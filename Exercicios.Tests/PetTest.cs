using Exercicios.Domain;

namespace Exercicios.Tests;

[TestClass]
public class PetTest
{

    private static List<IPet> _pets;

    [ClassInitialize]
    public static void Setup(TestContext context)
    {
        _pets = new List<IPet>();
        _pets.LoadPetsFromExternalFile("C:\\SystemIOClass\\pets.csv");
    }

    private static void PrintDogs(IEnumerable<IPet> dogs)
    {
        foreach (var dog in dogs)
        {
            Console.WriteLine($"{dog.GetAnimalType()}: {dog.Name} | {dog.Gender} | Breed and Size: {dog.Breed.Name}, {dog.Breed.Size} | Weight: {dog.Weight} | dog Owner: {dog.Owner.Name}");
        }
    }

    [TestMethod]
    public void LoadPetsFromExternalFileTest()
    {
        Assert.AreEqual(15, _pets.Count);
        foreach (var pet in _pets)
        {
            if (pet.GetAnimalType() == "Dog")
            Console.WriteLine($"{pet.GetAnimalType()}: {pet.Name} | {pet.Gender} | Breed and Size: {pet.Breed.Name}, {pet.Breed.Size} | Weight: {pet.Weight} | Pet Owner: {pet.Owner.Name}");
            else
            {
                Console.WriteLine($"{pet.GetAnimalType()}: {pet.Name} | {pet.Gender} | Peso: {pet.Weight} | Dono: {pet.Owner.Name}");
            }
        }
    }

    [TestMethod]
    public void LoadCatsLinqTest()
    {
        var query = from pet in _pets
                    where pet.GetAnimalType() == "Cat"
                    select pet;

        Assert.AreEqual(6, query.Count());
        foreach (var cat in query)
        {
            Console.WriteLine($"{cat.GetAnimalType()}: {cat.Name} | {cat.Gender} | Peso: {cat.Weight} | Dono: {cat.Owner.Name}");
        }
    }

    [TestMethod]
    public void LoadDogsLinqExtensionMethodsTest()
    {
        var query = _pets.Where(pet => pet.GetAnimalType() == "Dog");

        Assert.AreEqual(9, query.Count());
        PrintDogs(query);
    }

    [TestMethod]
    public void LoadDogsLinqOrderedTest()
    {
        var query = from pet in _pets
                    where pet.GetAnimalType() == "Dog"
                    orderby pet.Name
                    select pet;

        Assert.AreEqual(9, query.Count());
        PrintDogs(query);
    }

    [TestMethod]
    public void LoadDogsLinqOrderedWithExtensionMethodTest()
    {
        var query = _pets.Where(pet => pet.GetAnimalType() == "Dog")
            .OrderByDescending(pet => pet.Name);

        Assert.AreEqual(9, query.Count());
        PrintDogs(query);
    }

    [TestMethod]
    public void LoadDogsLinqProjectionTest()
    {
        var query = from pet in _pets
                    where pet.GetAnimalType() == "Dog"
                    orderby pet.Weight descending
                    select new { Name = pet.Name, Weight = pet.Weight };

        Assert.AreEqual(9, query.Count());

        foreach (var dog in query)
        {
            Console.WriteLine($"{dog.Name} | {dog.Weight}");
        }
    }

    [TestMethod]
    public void LoadDogsLinqProjectionExtensionMethodTest()
    {
        var query = _pets.Where(pet => pet.GetAnimalType() == "Dog")
            .OrderBy(pet => pet.Weight)
            .Select(pet => new { pet.Name, pet.Weight });

        Assert.AreEqual(9, query.Count());
        foreach (var dog in query)
        {
            Console.WriteLine($"{dog.Name} | {dog.Weight}");
        }
    }

    [TestMethod]
    public void LoadDogsLinqSkipAndTakeTest()
    {
        var query = (from pet in _pets
                    where pet.GetAnimalType() == "Dog"
                    orderby pet.Weight descending
                    select new { pet.Name, pet.Weight }).Skip(3).Take(5);

        Assert.AreEqual(5, query.Count());
        foreach (var dog in query)
        {
            Console.WriteLine($"{dog.Name} | {dog.Weight}");
        }
    }

    [TestMethod]
    public void LoadDogsLinqFirstAndLastTest()
    {
        var query =  from pet in _pets
                     where pet.GetAnimalType() == "Dog"
                     orderby pet.Weight descending
                     select new { pet.Name, pet.Weight };
        
        var firstDog = query.FirstOrDefault();
        var lastDog = query.LastOrDefault();

        Console.WriteLine(firstDog);
        Console.WriteLine(lastDog);
    }

    [TestMethod]
    public void LoadDogsLinqAggregationTest()
    {
        var query = from pet in _pets
                     where pet.GetAnimalType() == "Dog"
                     orderby pet.Weight descending
                     select new { pet.Name, pet.Weight };

        var weightSum = query.Sum(pet => pet.Weight);
        var weightMax = query.Max(pet => pet.Weight);
        var weightMin = query.Min(pet => pet.Weight);
        var weightAvg = query.Average(pet => pet.Weight);

        Console.WriteLine(weightSum);
        Console.WriteLine(weightMax);
        Console.WriteLine(weightMin);
        Console.WriteLine(weightAvg);
    }


    [TestMethod]
    public void LoadPetsLinqAgroupByGenderTest()
    {
        var query = from pet in _pets
                    group pet by pet.Gender into g
                    select new { Gender = g.Key, Total = g.Count() };

        foreach (var pet in query)
        {
            Console.WriteLine($"{pet.Gender} | {pet.Total}");
        }
    }

}