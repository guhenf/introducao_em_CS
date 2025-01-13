using Microsoft.VisualBasic;

namespace Exercicios.Domain;

public class Dog : IPet
{
    public string DogBark(short barksQtd)
    {
        var barks = "";

        for (var i = 0; i < barksQtd; i++)
        {
            barks = barks + "Woof! ";
        }
        return barks.TrimEnd();
    }

    public string HowMuchShouldDogEat(int weight)
    {
        //Metodo para calcular 5% do peso do Cachorro que deve ser q qtd para alimentacao diaria.
        //Weight em Kg * 1000 = peso em gramas. FoodToDog em Gramas.
        double foodToDog = weight * 1000 * 0.05;
        return $"Como o cão tem {weight}kg, ele deve comer {foodToDog}g por dia";
    }

    public string? Name { get; set; }

    public Gender Gender { get; set; }

    public string Photo { get; set; }

    public Breed Breed { get; set; }

    public bool Vaccinated { get; set; }

    public DateTime DateOfBirth { get; set; }
    public Owner Owner { get; set; }

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

    public List<string>? ValidateInfos()
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

    public List<string>? ValidateInfosTryCatch()
    {
        var errorMessages = new List<string>();

        try
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentException("Dog's name is required.");
            }

            // if (Gender != "Male" && Gender != "Female")
            // {
            //     throw new ArgumentException("Dog's gender is required, male or female.");
            // }

            if (DateOfBirth > DateTime.Today)
            {
                throw new ArgumentException("Dog's birth date cannot be in the future.");
            }

            if (Weight <= 0)
            {
                throw new ArgumentException("Dog's weight must be greater than zero.");
            }
        }
        catch (ArgumentException ex)
        {
            errorMessages.Add(ex.Message);
        }
        return errorMessages.Count == 0 ? null : errorMessages;
    }

    public string HowMuchHowMuchShouldDogEat(int weight)
    {
        throw new NotImplementedException();
    }

    void IPet.ValidateInfosTryCatch()
    {
        throw new NotImplementedException();
    }

    public double? Weight
    {
        set
        {
            if (value < 0)
            {
                _weight = null;
            }
            else
            {
                _weight = value;
            }
        }
        get
        {
            return _weight;
        }
    }

    private double? _weight;
}