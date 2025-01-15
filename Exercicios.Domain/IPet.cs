namespace Exercicios.Domain
{
    public interface IPet
    {
        string Name { get; set; }
        Gender Gender { get; set; }
        string Photo { get; set; }
        Owner Owner { get; set; }
        double Weight { get; set; }
        public Breed Breed { get; set; }

        string HowMuchShouldPetEat();
        List<string> ValidateInfosTryCatch();
    }
}
