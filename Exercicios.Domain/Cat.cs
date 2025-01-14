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
    public override string HowMuchShouldPetEat()
    {
        //Metodo para calcular 5% do peso do Cachorro que deve ser q qtd para alimentacao diaria.
        //Weight em Kg * 1000 = peso em gramas. FoodToDog em Gramas.
        double foodToCat = (double)Weight * 1000 * 0.01;
        return $"Como o gato tem {Weight}kg, ele deve comer {foodToCat}g por dia";
    }
    }   
}
