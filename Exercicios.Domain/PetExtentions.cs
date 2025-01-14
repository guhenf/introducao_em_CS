using System.Security.Cryptography.X509Certificates;

namespace Exercicios.Domain
{
    public static class PetExtentions
    {
        public static string GetAnimalType(this IPet pet)
        {
            return pet.GetType().Name;
        }

        public static void LoadPetsFromExternalFile(this List<IPet> pets, string url)
        {
            var fileLines = File.ReadAllLines(url);

            for (int i = 0; i < fileLines.Length; i++)
            {

                var onwers = new List<Owner>();
                var columns = fileLines[i].Split(";".ToCharArray());

                if (columns[0] == "Cachorro")
                {
                    var dog = new Dog();                    
                    dog.Name = columns[1];
                    dog.Gender = columns[2] == "Male" ? Gender.Male : Gender.Female;
                    // dog.Owner = ;
                    dog.Weight = double.Parse(columns[4]);  
                    // dog.Breed.Name = columns[5];
                    // dog.Breed.Size = result;
                    dog.DateOfBirth = Convert.ToDateTime(columns[7]);
                    dog.Vaccinated = columns[8] == "sim";
                        
                    pets.Add(dog);
                } 
                else if (columns[0] == "Gato") 
                {
                    var cat = new Cat();
                    cat.Name = columns[1];
                    cat.Gender = columns[2] == "Male" ? Gender.Male : Gender.Female;
                    // cat.Owner = ;
                    cat.Weight = double.Parse(columns[4]);
                    
                    pets.Add(cat);
                }
            }
        }
    }
}
