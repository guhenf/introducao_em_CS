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
            var owners = new List<Owner>();

            for (int i = 0; i < fileLines.Length; i++)
            {
                var onwers = new List<Owner>();
                var columns = fileLines[i].Split(";".ToCharArray());

                if (columns[0] == "Cachorro")
                {
                    var dog = new Dog();                    
                    dog.Name = columns[1];
                    dog.Gender = columns[2] == "Male" ? Gender.Male : Gender.Female;
                    dog.SetOwner(owners, columns[3]);
                    dog.Weight = double.Parse(columns[4]);
                    dog.Breed = new Breed() { Name = columns[5], Size = Enum.Parse<Size>(columns[6])};
                    dog.DateOfBirth = Convert.ToDateTime(columns[7]);
                    dog.Vaccinated = columns[8] == "sim";
                        
                    pets.Add(dog);
                } 
                else if (columns[0] == "Gato") 
                {
                    var cat = new Cat();
                    cat.Name = columns[1];
                    cat.Gender = columns[2] == "Male" ? Gender.Male : Gender.Female;
                    cat.SetOwner(owners, columns[3]);
                    cat.Weight = double.Parse(columns[4]);
                
                    pets.Add(cat);
                }
            }
        }

        private static Owner GetOwner(this List<Owner> owners, string ownerName)
        {
            foreach (var owner in owners) 
            {
                if (owner.Name == ownerName) return owner;
            }
            var newOwner = new Owner { Name = ownerName };
            owners.Add(newOwner);

            return newOwner;
        }

        private static void SetOwner(this IPet pet, List<Owner> owners, string petOwner)
        {
            var owner = owners.GetOwner(petOwner);
            owner.AddPet(pet);
        }
    }
}
