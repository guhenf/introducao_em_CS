using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void DogBarkTest()
        {
            Dog Fred = new Dog();
            string bark = Fred.DogBark();

            Console.WriteLine(bark);

            Assert.AreEqual("Woof Woof!", bark);
        }
        [TestMethod]
        public void HowMuchShouldDogEatTest_1()
        {
            Dog Fred = new Dog();
            string howMuchShouldDogEat = Fred.HowMuchShouldDogEat(1);
            Console.WriteLine(howMuchShouldDogEat);
            Assert.AreEqual("Como o cão tem 1kg, ele deve comer 50g por dia", howMuchShouldDogEat); 
        }
        [TestMethod]
        public void HowMuchShouldDogEatTest_2()
        {
            Dog Marley = new Dog();
            string howMuchShouldDogEat = Marley.HowMuchShouldDogEat(15);
            Console.WriteLine(howMuchShouldDogEat);
            Assert.AreEqual("Como o cão tem 15kg, ele deve comer 750g por dia", howMuchShouldDogEat); 
        }
        [TestMethod]
        public void HowMuchShouldDogEatTest_3()
        {
            Dog Max = new Dog();
            string howMuchShouldDogEat = Max.HowMuchShouldDogEat(30);
            Console.WriteLine(howMuchShouldDogEat);
            Assert.AreEqual("Como o cão tem 30kg, ele deve comer 1500g por dia", howMuchShouldDogEat); 
        }
    }
}