﻿using System;
using FairyWorld.Animals;

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

        internal void PlayLaserTag(Person person, ILaserTagMonsterFactory factory)
        {
            Console.WriteLine(person.GetName() + " will now play laser tag!");
            Console.WriteLine();

            var lowMon = factory.CreateLowTierMonster();
            Console.WriteLine("Fighting " + lowMon + "....Defeated.");
            Console.WriteLine();
            var midMon = factory.CreateMidTierMonster();
            Console.WriteLine("Fighting " + midMon + "....Defeated.");
            Console.WriteLine();
            var highMon = factory.CreateHighTierMonster();
            Console.WriteLine("Fighting " + highMon + "....Defeated.");
            Console.WriteLine();
            var flyMon = factory.CreateFlyingMonster();
            Console.WriteLine("Fighting " + flyMon + "....Defeated.");
            Console.WriteLine();
            var hybridMon = factory.CreateHybridMonster();
            Console.WriteLine("Fighting " + hybridMon + "....Defeated.");
            Console.WriteLine();
            var finalMon = factory.CreateFinalBossMonster();
            Console.WriteLine("Fighting " + finalMon + "....Defeated.");
            Console.WriteLine();

            Console.WriteLine("Congratulations! All monsters were defeated!");
            Console.WriteLine();
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
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

            fw.PlayLaserTag(jessica, new GenericLaserTagMonsterFactory());
            fw.PlayLaserTag(jessica, new AntarcticaLaserTagMonsterFactory());
            fw.PlayLaserTag(jessica, new MechaLaserTagMonsterFactory());
        }
    }
}