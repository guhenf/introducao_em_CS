using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass]

    public class DogTest
    {
        Dog BanBan = new Dog();

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

        [TestMethod]
        public void DogSetGetNameTest()
        {
            BanBan.SetName("BanBan");
            string name = BanBan.GetName();

            Console.WriteLine(name);
            Assert.AreEqual("BanBan", name);
        }
        
        [TestMethod]
        public void DogSetGetGenderTest()
        {
            BanBan.SetGender("Macho");
            string gender = BanBan.GetGender();

            Console.WriteLine(gender);
            Assert.AreEqual("Macho", gender);
        }

        [TestMethod]
        public void DogSetGetBreedTest()
        {
            BanBan.SetBreed("Basse");
            string breed = BanBan.GetBreed();

            Console.WriteLine(breed);
            Assert.AreEqual("Basse", breed);
        }

        [TestMethod]
        public void DogSetGetSizeTest()
        {
            BanBan.SetSize("Pequeno");
            string size = BanBan.GetSize();

            Console.WriteLine(size);
            Assert.AreEqual("Pequeno", size);
        }

        [TestMethod]
        public void DogSetGetAgeTest()
        {
            BanBan.SetAge(6);
            int age = BanBan.GetAge();

            Console.WriteLine(age);
            Assert.AreEqual(6, age);
        }

        [TestMethod]
        public void DogSetAgeShouldRejectNegativeTest()
        {
            BanBan.SetAge(-6);
            int age = BanBan.GetAge();
            
            Console.WriteLine($"A idade nao pode ser menor do que 0.");
            Assert.AreEqual(0, age);              
        }

        [TestMethod]
        public void DogSetGetWeightTest()
        {
            BanBan.SetWeight(10);
            double weight = BanBan.GetWeight();

            Console.WriteLine(weight);
            Assert.AreEqual(10, weight);
        }

        [TestMethod]
        public void DogSetGetWeightShouldRejectedNegativeTest()
        {
            BanBan.SetWeight(-10);
            double weight = BanBan.GetWeight();

            Console.WriteLine(weight);
            Assert.AreEqual(0, weight);
        }

        [TestMethod]
        public void DogIsVaccinatedTest()
        {
            BanBan.setVaccinated(true);
            bool dogIsVaccinated = BanBan.getVaccinated();

            Console.WriteLine(dogIsVaccinated);
            Assert.IsTrue(dogIsVaccinated);
        }

         [TestMethod]
        public void DogIsNotVaccinatedTest()
        {
            BanBan.setVaccinated(false);
            bool dogIsNotVaccinated = BanBan.getVaccinated();

            Console.WriteLine(dogIsNotVaccinated);
            Assert.IsFalse(dogIsNotVaccinated);
        }
    }
}