using System;
using FairyWorld.Attractions;
using FairyWorld.RentalPets;
using FairyWorld.Mosters.Factories;
using FairyWorld.ToyKits;
using FairyWorld.Themes;
using FairyWorld.Sandwiches;
using static FairyWorld.Sandwiches.FairyWorldSandwichDirector;
using FairyWorld.Vacations;
using FairyWorld.Stamps;
using System.Text;

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
            Console.WriteLine("Fighting " + lowMon.GetMonsterName() + "....Defeated.");
            Console.WriteLine();
            var midMon = factory.CreateMidTierMonster();
            Console.WriteLine("Fighting " + midMon.GetMonsterName() + "....Defeated.");
            Console.WriteLine();
            var highMon = factory.CreateHighTierMonster();
            Console.WriteLine("Fighting " + highMon.GetMonsterName() + "....Defeated.");
            Console.WriteLine();
            var flyMon = factory.CreateFlyingMonster();
            Console.WriteLine("Fighting " + flyMon.GetMonsterName() + "....Defeated.");
            Console.WriteLine();
            var hybridMon = factory.CreateHybridMonster();
            Console.WriteLine("Fighting " + hybridMon.GetMonsterName() + "....Defeated.");
            Console.WriteLine();
            var finalMon = factory.CreateFinalBossMonster();
            Console.WriteLine("Fighting " + finalMon.GetMonsterName() + "....Defeated.");
            Console.WriteLine();

            Console.WriteLine("Congratulations! All monsters were defeated!");
            Console.WriteLine();
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
        }

        internal void CreateAHumanoidToyByKit(Person person, IHumanoidToyKitFactory factory)
        {
            var robot = factory.CreateRobot();
            robot.MakeNoise();
            robot.Walk();
            robot.DisplayAssemblyLevel();
            var vampire = factory.CreateVampire();
            vampire.MakeNoise();
            vampire.Walk();
            vampire.DisplayAssemblyLevel();
            var werewolf = factory.CreateWerewolf();
            werewolf.MakeNoise();
            werewolf.Walk();
            werewolf.DisplayAssemblyLevel();
            var transformer = factory.CreateTransformer();
            transformer.MakeNoise();
            transformer.Walk();
            transformer.DisplayAssemblyLevel();
            var alien = factory.CreateAlien();
            alien.MakeNoise();
            alien.Walk();
            alien.DisplayAssemblyLevel();
            Console.WriteLine();
        }

        internal void DemoTheme(IFairyWorldThemeFactory factory)
        {
            var spring = factory.CreateSpring();
            displayThemeContent(spring);
            var summer = factory.CreateSummer();
            displayThemeContent(summer);
            var autumn = factory.CreateAutumn();
            displayThemeContent(autumn);
            var winter = factory.CreateWinter();
            displayThemeContent(winter);
            var halloween = factory.CreateHalloween();
            displayThemeContent(halloween);
            var valentine = factory.CreateValentine();
            displayThemeContent(valentine);
        }

        private void displayThemeContent(ITheme theme)
        {
            Console.WriteLine($"Poster: {theme.GetPoster()}");
            Console.WriteLine($"StringOfLights: {theme.GetStringOfLights()}");
            Console.WriteLine($"LightShow: {theme.LightShow()}");
            Console.WriteLine($"SongTitle: {theme.GetMusicSong().SongTitle}");
            Console.WriteLine($"Lyrics: {theme.GetMusicSong().Lyrics}");
            Console.WriteLine($"SongLength: {theme.GetMusicSong().SongLength.ToString("g")}");
            Console.WriteLine();

            foreach (var mascot in theme.GetMascots())
            {
                Console.WriteLine($"Mascot Name: {mascot.Name}");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        internal FastFood OrderSandwich(SandwichMenu item, SandwichSize itemSize)
        {
            var sandwichBuilder = new Builder("sandwich");

            switch (item)
            {
                case SandwichMenu.CHICKEN_AND_BACON:
                    FairyWorldSandwichDirector.ChickenAndBacon(sandwichBuilder);
                    break;
                case SandwichMenu.STEAK_AND_CHEESE:
                    FairyWorldSandwichDirector.SteakAndCheese(sandwichBuilder);
                    break;
                case SandwichMenu.SPICY_ITALIAN:
                    FairyWorldSandwichDirector.SpicyItalian(sandwichBuilder);
                    break;
                case SandwichMenu.TUNA_AND_EGG:
                    FairyWorldSandwichDirector.TunaAndEgg(sandwichBuilder);
                    break;
            }

            switch (itemSize)
            {
                case SandwichSize.FOOTLONG:
                    sandwichBuilder.SetSize(15.24);
                    break;
                case SandwichSize.HALF_FOOTLONG:
                    sandwichBuilder.SetSize(30.48);
                    break;
            }

            return sandwichBuilder.Build();
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

            fw.CreateAHumanoidToyByKit(jessica, new HumanoidToyKitFactory());

            fw.DemoTheme(new FairyWorldThemeFactory());

            var chickenAndBacon = fw.OrderSandwich(SandwichMenu.CHICKEN_AND_BACON, SandwichSize.FOOTLONG);
            Console.WriteLine(chickenAndBacon.GetString());
            Console.WriteLine(fw.OrderSandwich(SandwichMenu.STEAK_AND_CHEESE, SandwichSize.FOOTLONG).GetString());
            Console.WriteLine(fw.OrderSandwich(SandwichMenu.SPICY_ITALIAN, SandwichSize.HALF_FOOTLONG).GetString());
            Console.WriteLine(fw.OrderSandwich(SandwichMenu.TUNA_AND_EGG, SandwichSize.FOOTLONG).GetString());
            var hamburger = new Builder("hamburger")
                            .AddTopping1("Beef")
                            .AddCheese()
                            .Build();
            Console.WriteLine(hamburger.GetString());
            Console.WriteLine();

            var fwd = new VacationInvoiceBuilder();
            Console.WriteLine(VacationDirector.FamilyWeekDeluxe(fwd, DateTime.Now).Build().GetString());
            Console.WriteLine();
        }
    }
}