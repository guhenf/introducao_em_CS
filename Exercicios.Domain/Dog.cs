﻿namespace Exercicios.Domain;

public class Dog
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

    public string? Gender { get; set; }

    public string? Breed { get; set; }

    public string? Size { get; set; }

    public bool Vaccinated { get; set; }


    public int Age
    {
        set
        {
            if (value < 0)
            {
                _age = 0;
            }
            else
            {
                _age = value;
            }
        }
        get
        {
            return _age;
        }
    }
    private int _age;

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