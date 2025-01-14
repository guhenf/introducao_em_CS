using Exercicios.Tests;

namespace Exercicios.Domain;

public class Dog : Animal, IPet
{
    public bool Vaccinated { get; set; }
    public DateTime DateOfBirth { get; set; }

    public string DogBark(int barksQtd)
    {
        var barks = "";

        for (var i = 0; i < barksQtd; i++)
        {
            barks = barks + "Woof! ";
        }
        return barks.TrimEnd();
    }

    public override string HowMuchShouldPetEat()
    {
        //Metodo para calcular 5% do peso do Cachorro que deve ser q qtd para alimentacao diaria.
        //Weight em Kg * 1000 = peso em gramas. FoodToDog em Gramas.
        double foodToDog = Weight * 1000 * 0.05;
        return $"Como o cão tem {Weight}kg, ele deve comer {foodToDog}g por dia";
    }

    public string DogYearsOldCalc(DateTime dateOfBirth)
    {
        var today = DateTime.Today;
        int dogYears = today.Year - dateOfBirth.Year;
        int dogMonths = today.Month - dateOfBirth.Month + (12 * dogYears);

        if (dogMonths < 12)
        {
            return (dogMonths == 1) ? $"{dogMonths} Mes." : $"{dogMonths} Meses.";
        }
        else
        {
            return (dogYears == 1) ? $"{dogYears} Ano." : $"{dogYears} Anos.";
        }
    }

    public List<string> ValidateInfos()
    {
        var errorMessages = new List<string>();

        if (string.IsNullOrWhiteSpace(Name))
            errorMessages.Add("Dog's name is required.");

        // if (Gender != "Male" && Gender != "Female")
        //     errorMessages.Add("Dog's gender is required, male ou female.");

        if (DateOfBirth > DateTime.Today)
            errorMessages.Add("Dog's birth date cannot be in the future.");

        if (Weight <= 0)
            errorMessages.Add("Dog's weight most be greater than zero.");

        return errorMessages.Count == 0 ? null : errorMessages;
    }

    public override List<string> ValidateInfosTryCatch()
    {
        var errorMessages = CommonValidations();

        // if (Gender != "Male" && Gender != "Female")
        // {
        //     throw new ArgumentException("Dog's gender is required, male or female.");
        // }

        if (errorMessages == null)
            return null;

        if (DateOfBirth > DateTime.Today)
        errorMessages.Add("Dog's birth date cannot be in the future.");
        
        if (Weight <= 0)
        errorMessages.Add("Dog's weight must be greater than zero.");

        return errorMessages;
    }
}