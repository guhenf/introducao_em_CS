

namespace Exercicios.Domain;

public class Dog
{
   public string DogBark()
   {
      return "Woof Woof!"; 
   }

    public string HowMuchShouldDogEat(int weight)
   {
      //Metodo para calcular 5% do peso do Cachorro que deve ser q qtd para alimentacao diaria.
      //Weight em Kg * 1000 = peso em gramas. FoodToDog em Gramas.
      double foodToDog = weight * 1000 * 0.05;
      return $"Como o cão tem {weight}kg, ele deve comer {foodToDog}g por dia";
   }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    private string _name;

    public void SetGender(string gender)
    {
        _gender = gender;
    }
    public string GetGender()
    {
        return _gender;
    }
    private string _gender;

    public void SetBreed(string breed)
    {
        _breed = breed;
    }
    public string GetBreed()
    {
        return _breed;
    }
    private string _breed;

    public void SetSize(string size)
    {
        _size = size;
    }
    public string GetSize()
    {
        return _size;
    }
    private string _size;

     public void SetAge(int age)
    {
        if (age < 0){
            _age = 0;
        } else {
            _age = age;
        }
    }
    public int GetAge()
    {
        return _age;
    }
    private int _age;

    public void SetWeight(double weight)
    {
        if (weight < 0){
            _weight = 0;
        } else {
            _weight = weight;
        }
    }
    public double GetWeight()
    {
        return _weight;
    }
    private double _weight;
}