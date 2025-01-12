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
        public void TiposImplicitosTest()
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
            var date = DateTime.Parse("09/17/1998");
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

        [TestMethod]
        public void ArraysLoopWhileTest()
        {
            var array = new int[3];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;

            var index = 0;

            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
        }

        [TestMethod]
        public void ArraysLoopDoWhileTest()
        {
            var array = new string[] { "Frederico", "Marley", "Max" };

            var index = 0;
            // var index = -1

            do
            {
                Console.WriteLine(array[index]);
                // Console.WriteLine(array[index++]);
                // Console.WriteLine(array[++index]);
                index++;
            } while (index < array.Length);
        }

        [TestMethod]
        public void ArraysLoopForTest()
        {
            var array = new string[] { "CJ", "Pipoca", "Pidjey" };

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        [TestMethod]
        public void ArraysInvertedLoopForTest()
        {
            var array = new[] { 5, 50, 501 };

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        [TestMethod]
        public void ArraysForEachTest()
        {
            var collection = new[] { "Gustavo", "Henrique", "Franco" };

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void ListForEachTest()
        {
            var list = new List<string>() { "BMW" };
            list.Remove("BMW");
            list.Add("Toyota");
            list.Add("Mazda");
            list.Add("Honda");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void DictionaryTest()
        {
            var dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Audi");
            dictionary.Add(2, "BMW");
            dictionary.Add(3, "Alfa Romeo");
            // dictionay.Remove(item.key)

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        [TestMethod]
        public void ConditionIfElseTest()
        {
            var now = DateTime.Now;
            var number = now.Second;
            string message;

            if (number % 2 == 0)
            {
                message = "is even.";
            }
            else
            {
                message = "is odd.";
            }

            Console.WriteLine($"{number} {message}");
        }

        [TestMethod]
        public void ConditionIfElseTest_2()
        {
            var today = DateTime.Today;

            string message;

            if (today.DayOfWeek == DayOfWeek.Friday)
                message = "Sextou padrinho.";
            else if (today.DayOfWeek == DayOfWeek.Saturday)
                message = "Sabadasso bom demais.";
            else if (today.DayOfWeek == DayOfWeek.Sunday)
                message = "Amanha tem trabalho...";
            else
                message = "Estou so pela sexta.";

            Console.WriteLine(message);
        }

        [TestMethod]
        public void ConditionTernaryTest()
        {
            var now = DateTime.Now;
            var number = now.Second;

            string message = number % 2 != 0 ? $"{number} is odd" : $"{number} is even";

            Console.WriteLine(message);
        }

        [TestMethod]
        public void ConditionSwitchCaseTest()
        {
            var today = DateTime.Today;

            string message;

            switch (today.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    message = "Sextou padrinho.";
                    break;
                case DayOfWeek.Saturday:
                    message = "Sabadasso bom demais.";
                    break;
                case DayOfWeek.Sunday:
                    message = "Amanha tem trabalho...";
                    break;
                default:
                    message = "Estou so pela sexta.";
                    break;
            }

            Console.WriteLine(message);
        }

        [TestMethod]
        public void ExceptionTest()
        {
            var x = 10;
            var y = 0;

            try
            {
                var result = x / y;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"We cannot divide {x} by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally always runs here.");
            }
        }
    }
}
