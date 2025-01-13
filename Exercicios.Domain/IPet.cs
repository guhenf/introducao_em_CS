namespace Exercicios.Domain
{
    public interface IPet
    {
        string Name { get; set; }
        Gender Gender { get; set; }
        string Photo { get; set; }
        Owner Owner { get; set; }

        string HowMuchHowMuchShouldDogEat(int weight);
        void ValidateInfosTryCatch();
    }
}
