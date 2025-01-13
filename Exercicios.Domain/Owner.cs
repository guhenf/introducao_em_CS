

namespace Exercicios.Domain

{
   public class Owner
   {
      public string Name { get; set; }
      public string Phone { get; set; }
      public string Email { get; set; }

      public List<IPet> Pets { get; set; }

      public void AddPet(IPet pet)
      {
         if (Pets == null)
             Pets = new List<IPet>();

         Pets.Add(pet);
         pet.Owner = this;
      }

      public void AddPet(params IPet[] pets)
      {
            foreach (var pet in pets)
                AddPet(pet);   
        }

      public void RemovePet(IPet pet)
      {
         if (Pets == null)
            return;

         if (Pets.Remove(pet))
            pet.Owner = null;
      }

      public void RemovePet(params IPet[] pets)
      {
         foreach (var pet in pets)
         {
                RemovePet(pet);
         }      
      }
   }
}
