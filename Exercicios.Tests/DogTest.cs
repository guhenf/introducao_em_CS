using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass]

    public class DogTest
    {
        Dog BanBan = new Dog();

        [TestMethod]
        public void DogNameRequiredTest()
        {
            var Fred = new Dog
            {
                Name = "",
                Gender = "Male",
                DateOfBirth = new DateTime(2010, 03, 14),
                Weight = 3
            };

            var message = Fred.ValidateInfosTryCatch();

            Assert.AreEqual("Dog's name is required.", message[0]);
            Console.WriteLine(message[0]);
        }

        [TestMethod]
        public void DogGenderMostBeMaleOrFemaleTest()
        {
            var Fred = new Dog
            {
                Name = "Frederico",
                Gender = "Alienigena",
                DateOfBirth = new DateTime(2010, 03, 14),
                Weight = 3
            };

            var message = Fred.ValidateInfosTryCatch();

            Assert.AreEqual("Dog's gender is required, male or female.", message[0]);
            Console.WriteLine(message[0]);
        }

        [TestMethod]
        public void DogBirthDateCannotBeFutureDateTest()
        {
            var Fred = new Dog
            {
                Name = "Frederico",
                Gender = "Male",
                DateOfBirth = DateTime.Today.AddDays(1),
                Weight = 3
            };

            var message = Fred.ValidateInfosTryCatch();

            Assert.AreEqual("Dog's birth date cannot be in the future.", message[0]);
            Console.WriteLine(message[0]);
        }

        [TestMethod]
        public void DogWeigthMostBeGreaterThanZeroTest()
        {
            var Fred = new Dog
            {
                Name = "Frederico",
                Gender = "Male",
                DateOfBirth = new DateTime(2010, 03, 14),
                Weight = 0
            };


            var message = Fred.ValidateInfosTryCatch();

            Assert.AreEqual("Dog's weight must be greater than zero.", message[0]);
            Console.WriteLine(message[0]);
        }

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
        public void DogGetYearsOldInMonthsTest()
        {
            var Cj = new Dog();
            Cj.DateOfBirth = DateTime.Today.AddMonths(-4);
            var dogYersOld = Cj.DogYearsOldCalc(Cj.DateOfBirth);

            Console.WriteLine(dogYersOld);
            Assert.AreEqual("4 Meses.", dogYersOld);
        }

        [TestMethod]
        public void DogGetYearsOldOneMonthTest()
        {
            var Cj = new Dog();
            Cj.DateOfBirth = DateTime.Today.AddMonths(-1);
            var dogYersOld = Cj.DogYearsOldCalc(Cj.DateOfBirth);

            Console.WriteLine(dogYersOld);
            Assert.AreEqual("1 Mes.", dogYersOld);
        }

        [TestMethod]
        public void DogGetYearsOldInYearsTest()
        {
            var Frederico = new Dog();
            Frederico.DateOfBirth = DateTime.Today.AddYears(-15);
            var dogYersOld = Frederico.DogYearsOldCalc(Frederico.DateOfBirth);

            Console.WriteLine(dogYersOld);
            Assert.AreEqual("15 Anos.", dogYersOld);
        }

        [TestMethod]
        public void DogGetYearsOldOneYearTest()
        {
            var Frederico = new Dog();
            Frederico.DateOfBirth = DateTime.Today.AddYears(-1);
            var dogYersOld = Frederico.DogYearsOldCalc(Frederico.DateOfBirth);

            Console.WriteLine(dogYersOld);
            Assert.AreEqual("1 Ano.", dogYersOld);
        }

        [TestMethod]
        public void DogSetGetWeightTest()
        {
            BanBan.Weight = 10;
            var weight = BanBan.Weight;

            Console.WriteLine(weight);
            Assert.AreEqual(10, weight);
        }

        [TestMethod]
        public void DogSetGetWeightShouldRejectedNegativeTest()
        {
            BanBan.Weight = -10;
            var weight = BanBan.Weight;

            Console.WriteLine(weight);
            Assert.AreEqual(null, weight);
        }
        [TestMethod]

        public void DogSetGetWeightNullableTest()
        {
            BanBan.Weight = null;
            var weight = BanBan.Weight;

            Console.WriteLine(weight);
            Assert.AreEqual(null, weight);
        }

        [TestMethod]
        public void DogOwnerAssociationTest()
        {
            var Gustavo = new Owner
            {
                Name = "Gustavo",
                Phone = "19 999796305",
                Email = "guhenf@gmail.com"
            };

            var BanBan = new Dog
            {
                Name = "CJ",
                Owner = Gustavo,
            };

            Console.WriteLine(BanBan.Owner.Name);
            Assert.AreEqual("Gustavo", BanBan.Owner.Name);
        }
    }
}