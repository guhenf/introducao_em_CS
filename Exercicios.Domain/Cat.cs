using Exercicios.Tests;

namespace Exercicios.Domain
{
    public class Cat : Animal, IPet
    {
        public string CatMeow(int meowQtd)
        {
            var meow = "";

            for (var i = 0; i < meowQtd; i++)
            {
                meow = meow + "Meow! ";
            }
            return meow.TrimEnd();
        }
    }
}
