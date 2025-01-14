namespace Exercicios.Domain
{
    public static class PetExtentions
    {
        public static string GetAnimalType(this IPet pet)
        {
            return pet.GetType().Name;
        }
    }
}
