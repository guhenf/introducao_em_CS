using Exercicios.Domain;

namespace Exercicios.Tests
{
[TestClass]
public class HelloWorldTest
    {
        [TestMethod]
        public void SayHelloTest()
        {
           string msg = HelloWorld.SayHello();
           Assert.AreEqual("Hello World!", msg);
        }
    }
}
