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
        //abstract method
        public abstract void MakesNoise(); //abstract method (NO GET SET) NO DEFINITIONS {}. This will be required to specify for each Pet. 
        public virtual void Bark() //virtual method. CAN HAVE DEFINITION {}. This is an OPTIONAL method that can be called in all Pets. You can override it as will to do something else.
        {
            Console.WriteLine("Bark!");
        }
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

        public override void MakesNoise() //override our MakesNoise with our virtual we created in pet.
        {
            this.Bark();
        }
    }

    //Below is an example created during review w/ Casey Wilson 12/5
    //public class Husky : Dog
    //{
        //public override void Bark()
        //{
            //Console.WriteLine("hooouuuulllowowowoowowoowowow");
        //}
    //}

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

        public override void MakesNoise()
        {
            Console.WriteLine("Meow!");
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
        public override void MakesNoise()
        {
            Console.WriteLine("I probably don't make much of any noise.");
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
        public override void MakesNoise()
        {
            throw new NotImplementedException(); //throws an exception (because I think there are too many noises other animals could make)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Pembroke Welsh Corgi", false, "Kiki", 15.2, "Catherine", "Jingle");
            var cat = new Cat("Domestic Shorthair", true, "Sugar", 20.7, "Andrew", "Yang");
            var reptile = new Reptile("Ball Python", false, "Dex", 7.7, "Hector", "Allen");
            var otherPet = new OtherPet("Mammal", "Goat", "Charles", 30.1, "Mary", "Anderson");

            //var husky = new Husky();
            //husky.MakesNoise();
            //Console.ReadLine();
        }
    }
}
