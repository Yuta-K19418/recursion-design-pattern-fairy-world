using System;

namespace FairyWorld
{
    internal class FairyWorld
    {
        internal void RentPet(PlayfulPetAssistant assistant, Person person)
        {
            Console.WriteLine("Thank you for your pet rental!");
            double costs = assistant.RunAssistanceTour(person);
            Console.WriteLine(costs + " dollars were charged to " + person.GetName() + "'s credit card.");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var fw = new FairyWorld();
            var jessica = new Person("Jessica", "Roller", 30, 1.65, 95, "female");
            fw.RentPet(new PlayfulCatAssistant(), jessica);
        }
    }
}