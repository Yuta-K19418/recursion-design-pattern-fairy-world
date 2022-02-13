using System;

namespace FairyWorld
{
    internal class FairyWorld
    {
        private Dictionary<string, PlayfulPetAssistant> playfulPetAssistantDic = new Dictionary<string, PlayfulPetAssistant>();

        internal void AddPlayfulPetAssistant(string petKey, PlayfulPetAssistant assistant)
        {
            playfulPetAssistantDic.Add(petKey, assistant);
        }

        internal void RentPet(string petKey, Person person, int amount, string tour)
        {
            Console.WriteLine("Thank you for your pet rental!");
            double costs = amount == 1
                ? playfulPetAssistantDic[petKey].RunAssistanceTour(person, tour)
                : playfulPetAssistantDic[petKey].RunAssistanceTour(person, tour, amount);
            Console.WriteLine(costs + " dollars were charged to " + person.GetName() + "'s credit card.");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
        }

        private Dictionary<string, RideExperience> rideExperienceDic  = new Dictionary<string, RideExperience>();

        internal void AddRideExperience(string attractionKey, RideExperience experience)
        {
            rideExperienceDic.Add(attractionKey, experience);
        }

        internal void RideAttraction(string attractionKey, Person person, StateOfAffairs state)
        {
            rideExperienceDic[attractionKey].Ride(person, state);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var fw = new FairyWorld();
            fw.AddPlayfulPetAssistant("cat", new PlayfulCatAssistant());
            fw.AddPlayfulPetAssistant("dog", new PlayfulDogAssistant());
            fw.AddPlayfulPetAssistant("rabbit", new PlayfulRabbitAssistant());

            var jessica = new Person("Jessica", "Roller", 30, 1.65, 95, "female");
            fw.RentPet("cat", jessica, 2, "deluxe rounder pack");

            fw.AddRideExperience("Family Coasters", new RideFamilyCoastersExperience());
            fw.AddRideExperience("Inverted Coasters", new RideInvertedCoastersExperience());
            var state = new StateOfAffairs(10, 20, 70, "Feeling fun!");
            fw.RideAttraction("Family Coasters", jessica, state);

        }
    }
}