using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenges
{
    public abstract class Pet
    {
        public string PetName { get; set; }
        public double Weight { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        // public abstract string OwnerNotes { get; set; }
        public Pet() { }
        public Pet(string petName, double weight, string ownerFirstName, string ownerLastName)
        {
            PetName = petName;
            Weight = weight;
            OwnerFirstName = ownerFirstName;
            OwnerLastName = ownerLastName;
        }

    }
    public class Dog : Pet
    {
        public string Breed { get; set; }
        public bool NeedsTeamWhenHandled { get; set; }
        //public abstract override OwnerNotes{}
        public Dog() { }
        public Dog(string breed, bool needsTeamWhenHandled, string petName, double weight, string ownerFirstName, string ownerLastName)
            : base(petName, weight, ownerFirstName, ownerLastName)
        {
            Breed = breed;
            NeedsTeamWhenHandled = needsTeamWhenHandled;
        }
    }
    public class Cat : Pet
    {
        public string Breed { get; set; }
        public bool HasFelV { get; set; }
        public Cat(string breed, bool hasFelV, string petName, double weight, string ownerFirstName, string ownerLastName)
           : base(petName, weight, ownerFirstName, ownerLastName)
        {
            Breed = breed;
            HasFelV = hasFelV;
        }

    }
    public class Reptile : Pet
    {
        public string Species { get; set; }
        public bool Venomous { get; set; }
        public Reptile(string species, bool venomous, string petName, double weight, string ownerFirstName, string ownerLastName)
           : base(petName, weight, ownerFirstName, ownerLastName)
        {
            Species = species;
            Venomous = venomous;
        }
    }
    public class OtherPet : Pet
    {
        public string BiologicalClass { get; set; }
        public string Species { get; set; }
        public OtherPet(string biologicalClass, string species, string petName, double weight, string ownerFirstName, string ownerLastName)
           : base(petName, weight, ownerFirstName, ownerLastName)
        {
            BiologicalClass = biologicalClass;
            Species = species;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Dog = new Dog("Pembroke Welsh Corgi", false, "Kiki", 15.2, "Catherine", "Jingle");
            var Cat = new Cat("Domestic Shorthair", true, "Sugar", 20.7, "Andrew", "Yang");
            var Reptile = new Reptile("Ball Python", false, "Dex", 7.7, "Hector", "Allen");
            var OtherPet = new OtherPet("Mammal", "Goat", "Charles", 30.1, "Mary", "Anderson");

        }
    }
}
