
namespace Exercicios.Domain;

public class Dog
{
   public string DogBark()
   {
      return "Woof Woof!";
   }

   public string HowMuchShouldDogEat(int Weight)
   {
      double FoodToDog = Weight * 1000 * 0.05;
      return $"Como o cão tem {Weight}kg, ele deve comer {FoodToDog}g por dia";
   }
}
