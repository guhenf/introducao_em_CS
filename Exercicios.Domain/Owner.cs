

namespace Exercicios.Domain

{
   public class Owner
   {
      public string Name { get; set; }
      public string Phone { get; set; }
      public string Email { get; set; }

      public List<Dog> Pets { get; set; }

      public void AddPet(Dog pet)
      {
         if (Pets == null)
             Pets = new List<Dog>();

         Pets.Add(pet);
         pet.Owner = this;
      }

      public void AddPet(Dog[] pets)
      {
            if (Pets == null)
                Pets = new List<Dog>();

            Pets.AddRange(pets);

            foreach (var pet in pets)
            {
                pet.Owner = this;
            }
        }

      public void RemovePet(Dog pet)
      {
         if (Pets == null)
            return;

         if (Pets.Remove(pet))
            pet.Owner = null;
      }

      public void RemovePet(Dog[] pets)
      {
         if (Pets == null)
            return;

            foreach (var pet in pets)
            {
                if (Pets.Remove(pet))
                    pet.Owner = null;
            }      
      }
   }
}
