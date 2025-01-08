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
    }
}
