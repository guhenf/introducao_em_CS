using Exercicios.Domain;

namespace Exercicios.Tests;

[TestClass]
public class PetTest
{
    [TestMethod]
    public void LoadPetsFromExternalFileTest()
    {
        var pets = new List<IPet>();

        pets.LoadPetsFromExternalFile("C:\\SystemIOClass\\pets.csv");

        Assert.AreEqual(15, pets.Count);
        foreach (var pet in pets)
        {
            if (pet.GetAnimalType() == "Dog")
            Console.WriteLine($"{pet.GetAnimalType()}: {pet.Name} | {pet.Gender} | Breed and Size: {pet.Breed.Name}, {pet.Breed.Size} | Weight: {pet.Weight} | Pet Owner: {pet.Owner.Name}");
            else
            {
                Console.WriteLine($"{pet.GetAnimalType()}: {pet.Name} | {pet.Gender} | Peso: {pet.Weight} | Dono: {pet.Owner.Name}");
            }
        }
    }
}