using Exercicios.Domain;

namespace Exercicios.Tests;

[TestClass]
public class CatTest
{
    [TestMethod]
    public void CatMeowTest()
    {
        var Botas = new Cat();
        var meow = Botas.CatMeow(1);

        Console.WriteLine(meow);
        Assert.AreEqual("Meow!", meow);
    }

    [TestMethod]
    public void CatNameRequiredTest()
    {
        var Botas = new Cat
        {
            Name = "",
            Gender = Gender.Male,
        };

        var message = Botas.ValidateInfosTryCatch();

        Assert.AreEqual("Pet's name is required.", message[0]);
        Console.WriteLine(message[0]);
    }
}