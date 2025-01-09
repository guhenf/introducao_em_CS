using Exercicios.Domain;

namespace Exercicios.Tests

{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string message = HelloWorld.SayHello();

            Assert.AreEqual("Hello World!", message);

            Console.WriteLine(message);
        }

        [TestMethod]
        public void TiposPrimitivosEComplexosTest()
        {
            // Primitive types
            string message = "Hello Marley!";
            double decimalNum = 7.01;
            int integerNum = 4;

            Console.WriteLine(message);
            Console.WriteLine(integerNum);
            Console.WriteLine(decimalNum);

            // Complex types
            Dog Marley = new Dog();
            Console.WriteLine(Marley);
        }

        [TestMethod]
        public void ConversaoImplicitaTest()
        {
            int integerNum = 10;
            double value = integerNum;

            Console.WriteLine(value);
            Assert.AreEqual(integerNum, value);
        }

        [TestMethod]
        public void ConversaoExplicitaTest()
        {
            double value = 1.07;
            int integerNum = (int)value;

            Console.WriteLine(integerNum);
            Assert.AreNotEqual(value, integerNum);
        }

        [TestMethod]
        public void Tipo_de_value_Test()
        {
            int value = 10;
            HelloWorld.PassValue(value);

            Console.WriteLine(value);
            Assert.AreEqual(10, value);
        }

        [TestMethod]
        public void TipoDeReferenciaTest()
        {
            Dog Dog = new Dog();
            Dog.Name = "Frederico";

            HelloWorld.PassReference(Dog);

            string DogName = Dog.Name;

            Console.WriteLine(DogName);
            Assert.AreEqual("Frederico", DogName);
        }

        [TestMethod]
        public void IgualdadeEntreTiposDeValoresTest()
        {
            int value1 = 10;
            int value2 = 10;

            Assert.AreEqual(value1, value2);
        }

        [TestMethod]
        public void DesigualdadeEntreTiposDeReferenciaTest()
        {
            Dog Dog1 = new Dog();
            Dog1.Name = "Max";

            Dog Dog2 = new Dog();
            Dog2.Name = "Max";

            Assert.AreNotEqual(Dog1, Dog2);
        }

        [TestMethod]
        public void IgualdadeEntreTiposDeReferenciaTest()
        {
            Dog Dog1 = new Dog();
            Dog1.Name = "CJ";

            Dog Dog2 = Dog1;

            Assert.AreEqual(Dog1, Dog2);

            Console.WriteLine(Dog2.Name);
        }

        [TestMethod]
        public void TiposExplicitosTest()
        {
            string name = "CJ";
            double age = 0.5;
            int weight = 2;
            Dog Dog = new Dog();

            Assert.AreEqual(typeof(string), name.GetType());
            Assert.AreEqual(typeof(double), age.GetType());
            Assert.AreEqual(typeof(int), weight.GetType());
            Assert.AreEqual(typeof(Dog), Dog.GetType());
        }

        [TestMethod]
        public void Tipos_Implicitos_Test()
        {
            var name = "CJ";
            var age = 0.5;
            var weight = 2;
            var Dog = new Dog();

            Assert.AreEqual(typeof(string), name.GetType());
            Assert.AreEqual(typeof(double), age.GetType());
            Assert.AreEqual(typeof(int), weight.GetType());
            Assert.AreEqual(typeof(Dog), Dog.GetType());
        }

        [TestMethod]
        public void DateTimeToday_Test()
        {
            var today = DateTime.Today;
            Console.WriteLine(today);
        }

        [TestMethod]
        public void DateTimeNow_Test()
        {
            var now = DateTime.Now;

            Console.WriteLine(now);
            Console.WriteLine(now.Year);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Day);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);
            Console.WriteLine(now.Millisecond);
            Console.WriteLine(now.DayOfYear);
        }

        [TestMethod]
        public void DateTimeAddTime()
        {
            var now = DateTime.Now;
            var add5Hours = now.AddHours(5);
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            var nextMonth = now.AddMonths(1);

            Console.WriteLine(add5Hours);
            Console.WriteLine(tomorrow.DayOfWeek);
            Console.WriteLine(yesterday.DayOfWeek);
            Console.WriteLine(nextMonth.Month);
        }

        [TestMethod]
        public void DateTimeInitialize_Test()
        {
            var my2025Birthday = new DateTime(2025, 09, 17);

            Console.WriteLine(my2025Birthday);
            Console.WriteLine(my2025Birthday.DayOfWeek);
        }

        [TestMethod]
        public void DateTimeConvert_Test()
        {
            var date = DateTime.Parse("17/09/1998 04:00");
            Console.WriteLine(date);
            Console.WriteLine(date.DayOfWeek);
        }

        [TestMethod]
        public void DaysOfMonth()
        {
            var daysInMonth = DateTime.DaysInMonth(2025, 2);
            var lastDayInMonth = new DateTime(2025, 2, daysInMonth);

            Console.WriteLine(daysInMonth);
            Console.WriteLine(lastDayInMonth);

        }

        [TestMethod]
        public void DateTimeFormat_Test()
        {
            var now = DateTime.Now;

            Console.WriteLine(now);
            Console.WriteLine(now.ToString("f"));
            Console.WriteLine(now.ToString("dd/MM/yyyy"));
            Console.WriteLine(now.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine(now.ToString("MMM/yyyy"));
        }

        [TestMethod]
        public void TimeSpan_Test()
        {
            var myBirthday = new DateTime(1998, 09, 17);
            var myWifeBirthday = new DateTime(2000, 02, 10); ;

            var dif = myWifeBirthday.Subtract(myBirthday);

            Console.WriteLine(dif.TotalDays);
        }
    }
}
