using Exercicios.Domain;

namespace Exercicios.Tests
{
   [TestClass]

   public class OwnerTest
   {
      [TestMethod]
      public void OwnerAddPetTest()
      {
         var Cj = new Dog { Name = "CJ" };
         var Marley = new Dog { Name = "Marley" };
         var Frederico = new Dog { Name = "Frederico" };
         var Botas = new Cat { Name = "Botas" };

            var Gustavo = new Owner { Name = "Gustavo" };
         var Silvana = new Owner { Name = "Silvana" };

         Gustavo.Pets = new List<IPet>();
         Silvana.Pets = new List<IPet>();

         Gustavo.AddPet(Cj);
         Silvana.AddPet(Marley);
         Silvana.AddPet(Frederico);
         Silvana.AddPet(Botas);

         Assert.AreEqual(3, Silvana.Pets.Count);
         Assert.AreEqual(Silvana, Marley.Owner);
         Assert.AreEqual(Silvana, Frederico.Owner);
         Assert.AreEqual(Silvana, Botas.Owner);

            foreach (var pet in Silvana.Pets)
            Console.WriteLine($"{pet.GetType().Name}: {pet.Name}");
      }

      [TestMethod]
      public void OwnerAddPetWithCollectionAssociationTest()
      {
         var Cj = new Dog { Name = "CJ" };
         var Pipoca = new Dog { Name = "Pipoca" };

         var Gustavo = new Owner { Name = "Gustavo" };

         Gustavo.AddPet(Cj);
         Gustavo.AddPet(Pipoca);

         Assert.AreEqual(2, Gustavo.Pets.Count);
         Assert.AreEqual(Gustavo, Pipoca.Owner);
         Assert.AreEqual(Gustavo, Cj.Owner);

         foreach (var pet in Gustavo.Pets)
            Console.WriteLine(pet.Name);
      }

      [TestMethod]
      public void OwnerRemovePetWithCollectionAssociationTest()
      {
         var Cj = new Dog { Name = "CJ" };
         var Max = new Dog { Name = "Max" };

         var Gustavo = new Owner { Name = "Gustavo" };

         Gustavo.AddPet(Cj);
         Gustavo.AddPet(Max);

         Gustavo.RemovePet(Max);

         Assert.AreEqual(1, Gustavo.Pets.Count);
         Assert.AreEqual(null, Max.Owner);
         Assert.AreEqual(Gustavo, Cj.Owner);

         foreach (var pet in Gustavo.Pets)
            Console.WriteLine(pet.Name);
      }

      [TestMethod]
      public void OwnerAddPetsWithCollectionAssociationTest()
      {
         var Cj = new Dog { Name = "CJ" };
         var Max = new Dog { Name = "Max" };
         var Botas = new Cat { Name = "Botas" };

         var Gustavo = new Owner { Name = "Gustavo" };

         var Pets = new IPet[] { Cj, Max, Botas };

         Gustavo.AddPet(Pets);

         Gustavo.RemovePet(Max, Botas);

         Assert.AreEqual(1, Gustavo.Pets.Count);
         Assert.AreEqual(null, Max.Owner);
         Assert.AreEqual(Gustavo, Cj.Owner);

         foreach (var pet in Gustavo.Pets)
            Console.WriteLine(pet.Name);
      }

      [TestMethod]
      public void OwnerRemovePetsWithCollectionAssociationTest()
      {
         var Cj = new Dog { Name = "CJ" };
         var Max = new Dog { Name = "Max" };
         var Frederico = new Dog { Name = "Frederico" };
         var Botas = new Cat { Name = "Botas" };

         var Gustavo = new Owner { Name = "Gustavo" };

         var PetsToAdd = new IPet[] { Cj, Max, Frederico, Botas };
         var PetsToRemove = new IPet[] { Max, Frederico, Botas };

         Gustavo.AddPet(PetsToAdd);
         Gustavo.RemovePet(PetsToRemove);

         Assert.AreEqual(1, Gustavo.Pets.Count);
         Assert.AreEqual(null, Max.Owner);
         Assert.AreEqual(null, Frederico.Owner);
         Assert.AreEqual(Gustavo, Cj.Owner);

         foreach (var pet in Gustavo.Pets)
            Console.WriteLine(pet.Name);
      }
   }
}