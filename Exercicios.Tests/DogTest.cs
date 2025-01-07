using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass]

    public class DogTest
    {
        Dog BanBan = new Dog();

        [TestMethod]
        public void DogBarkTest_1()
        {
            var Fred = new Dog();
            var bark = Fred.DogBark(3);

            Console.WriteLine(bark);
            Assert.AreEqual("Woof! Woof! Woof!", bark);
        }

        [TestMethod]
        public void DogBarkTest_2()
        {
            var Fred = new Dog();
            var bark = Fred.DogBark(9);

            Console.WriteLine(bark);
            Assert.AreEqual("Woof! Woof! Woof! Woof! Woof! Woof! Woof! Woof! Woof!", bark);
        }

        [TestMethod]
        public void HowMuchShouldDogEatTest_1()
        {
            var Fred = new Dog();
            var howMuchShouldDogEat = Fred.HowMuchShouldDogEat(1);

            Console.WriteLine(howMuchShouldDogEat);
            Assert.AreEqual("Como o cão tem 1kg, ele deve comer 50g por dia", howMuchShouldDogEat);
        }

        [TestMethod]
        public void HowMuchShouldDogEatTest_2()
        {
            var Marley = new Dog();
            var howMuchShouldDogEat = Marley.HowMuchShouldDogEat(15);

            Console.WriteLine(howMuchShouldDogEat);
            Assert.AreEqual("Como o cão tem 15kg, ele deve comer 750g por dia", howMuchShouldDogEat);
        }

        [TestMethod]
        public void HowMuchShouldDogEatTest_3()
        {
            var Max = new Dog();
            var howMuchShouldDogEat = Max.HowMuchShouldDogEat(30);

            Console.WriteLine(howMuchShouldDogEat);
            Assert.AreEqual("Como o cão tem 30kg, ele deve comer 1500g por dia", howMuchShouldDogEat);
        }

        [TestMethod]
        public void DogSetGetNameTest()
        {
            BanBan.SetName("BanBan");
            var name = BanBan.GetName();

            Console.WriteLine(name);
            Assert.AreEqual("BanBan", name);
        }

        [TestMethod]
        public void DogSetGetGenderTest()
        {
            BanBan.SetGender("Macho");
            var gender = BanBan.GetGender();

            Console.WriteLine(gender);
            Assert.AreEqual("Macho", gender);
        }

        [TestMethod]
        public void DogSetGetBreedTest()
        {
            BanBan.SetBreed("Basse");
            var breed = BanBan.GetBreed();

            Console.WriteLine(breed);
            Assert.AreEqual("Basse", breed);
        }

        [TestMethod]
        public void DogSetGetSizeTest()
        {
            BanBan.SetSize("Pequeno");
            var size = BanBan.GetSize();

            Console.WriteLine(size);
            Assert.AreEqual("Pequeno", size);
        }

        [TestMethod]
        public void DogSetGetAgeTest()
        {
            BanBan.SetAge(6);
            var age = BanBan.GetAge();

            Console.WriteLine(age);
            Assert.AreEqual(6, age);
        }

        [TestMethod]
        public void DogSetAgeShouldRejectNegativeTest()
        {
            BanBan.SetAge(-6);
            var age = BanBan.GetAge();

            Console.WriteLine($"A idade nao pode ser menor do que 0.");
            Assert.AreEqual(0, age);
        }

        [TestMethod]
        public void DogSetGetWeightTest()
        {
            BanBan.SetWeight(10);
            var weight = BanBan.GetWeight();

            Console.WriteLine(weight);
            Assert.AreEqual(10, weight);
        }

        [TestMethod]
        public void DogSetGetWeightShouldRejectedNegativeTest()
        {
            BanBan.SetWeight(-10);
            var weight = BanBan.GetWeight();

            Console.WriteLine(weight);
            Assert.AreEqual(null, weight);
        }
        [TestMethod]

        public void DogSetGetWeightNullableTest()
        {
            BanBan.SetWeight(null);
            var weight = BanBan.GetWeight();

            Console.WriteLine(weight);
            Assert.AreEqual(null, weight);
        }

        [TestMethod]
        public void DogIsVaccinatedTest()
        {
            BanBan.setVaccinated(true);
            var dogIsVaccinated = BanBan.getVaccinated();

            Console.WriteLine(dogIsVaccinated);
            Assert.IsTrue(dogIsVaccinated);
        }

        [TestMethod]
        public void DogIsNotVaccinatedTest()
        {
            BanBan.setVaccinated(false);
            var dogIsNotVaccinated = BanBan.getVaccinated();

            Console.WriteLine(dogIsNotVaccinated);
            Assert.IsFalse(dogIsNotVaccinated);
        }
    }
}