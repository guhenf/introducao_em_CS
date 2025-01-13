using Exercicios.Domain;

namespace Exercicios.Tests
{
    public class Animal
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Photo { get; set; }
        public Breed Breed { get; set; }
        public Owner Owner { get; set; }

        public virtual string HowMuchShouldPetEat(int weight)
        {
            throw new NotImplementedException();
        }

        protected List<string>? CommonValidations()
        {
            var errorMessages = new List<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(Name))
                {
                    throw new ArgumentException("Pet's name is required.");
                }
            }
            catch (ArgumentException ex)
            {
                errorMessages.Add(ex.Message);
            }
            return errorMessages;
        }

        public virtual List<string>? ValidateInfosTryCatch()
        {
            var errorMessages = CommonValidations();

            if (errorMessages == null)
                return null;

            return errorMessages;
            
        }
    }
}
