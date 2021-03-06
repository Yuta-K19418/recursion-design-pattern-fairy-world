using System;
using FairyWorld.Attractions;
using FairyWorld.RentalPets;
using FairyWorld.Mosters;
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
            fightMonsters(lowMon);
            var midMon = factory.CreateMidTierMonster();
            fightMonsters(midMon);
            var highMon = factory.CreateHighTierMonster();
            fightMonsters(highMon);
            var flyMon = factory.CreateFlyingMonster();
            fightMonsters(flyMon);
            var hybridMon = factory.CreateHybridMonster();
            fightMonsters(hybridMon);
            var finalMon = factory.CreateFinalBossMonster();
            fightMonsters(finalMon);

            Console.WriteLine("Congratulations! All monsters were defeated!");
            Console.WriteLine();
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine();
        }

        private void fightMonsters(IMonster monster)
        {
            Console.WriteLine("Fighting " + monster.GetMonsterName() + "....Defeated.");
            Console.WriteLine();
        }

        internal void CreateAHumanoidToyByKit(Person person, IHumanoidToyKitFactory factory)
        {
            var robot = factory.CreateRobot();
            act(robot);
            var vampire = factory.CreateVampire();
            act(vampire);
            var werewolf = factory.CreateWerewolf();
            act(werewolf);
            var transformer = factory.CreateTransformer();
            act(transformer);
            var alien = factory.CreateAlien();
            act(alien);
        }

        private void act(IHumanoidToyKit toyKit)
        {
            toyKit.MakeNoise();
            toyKit.Walk();
            toyKit.DisplayAssemblyLevel();
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

        internal void PhotoBoothShoot(int[] stampSlots)
        {
            foreach (var stampSlotKey in stampSlots)
            {
                var stamp = StampPrototypeFactory.GetStamp(stampSlotKey);
                if (stamp != null)
                {
                    Console.WriteLine("Stamp - " + stamp + " used in the photoshoot!");
                    Console.WriteLine("-> " + stamp.GetString());
                }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var fw = new FairyWorld();
            var jessica = new Person("Jessica", "Roller", 30, 1.65, 95, "female");
            rentPlayfulPetAssistant(ref fw, jessica);
            var state = new StateOfAffairs(10, 20, 70, "Feeling fun!");
            experienceAttraction(ref fw, jessica, state);

            fw.PlayLaserTag(jessica, new GenericLaserTagMonsterFactory());
            fw.PlayLaserTag(jessica, new AntarcticaLaserTagMonsterFactory());
            fw.PlayLaserTag(jessica, new MechaLaserTagMonsterFactory());

            fw.CreateAHumanoidToyByKit(jessica, new HumanoidToyKitFactory());

            fw.DemoTheme(new FairyWorldThemeFactory());

            eatFastFood(ref fw);

            var fwd = new VacationInvoiceBuilder();
            Console.WriteLine(VacationDirector.FamilyWeekDeluxe(fwd, DateTime.Now).Build().GetString());
            Console.WriteLine();

            displayStamps(ref fw);
        }

        private static void rentPlayfulPetAssistant(ref FairyWorld fw, Person person)
        {
            fw.AddPlayfulPetAssistant("cat", new PlayfulCatAssistant());
            fw.AddPlayfulPetAssistant("dog", new PlayfulDogAssistant());
            fw.AddPlayfulPetAssistant("rabbit", new PlayfulRabbitAssistant());
            fw.RentPet("cat", person, 2, "deluxe rounder pack");

        }

        private static void experienceAttraction(ref FairyWorld fw, Person person, StateOfAffairs state)
        {
            fw.AddRideExperience("Family Coasters", new RideFamilyCoastersExperience());
            fw.AddRideExperience("Inverted Coasters", new RideInvertedCoastersExperience());
            fw.RideAttraction("Family Coasters", person, state);
        }

        private static void eatFastFood(ref FairyWorld fw)
        {
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
        }

        private static void displayStamps(ref FairyWorld fw)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StampPrototypeFactory.UpdatePrototype(4, new StarStamp("#f1c40f"));
            StampPrototypeFactory.UpdatePrototype(5, new TreeStamp("#2980b9"));
            StampPrototypeFactory.UpdatePrototype(6, new RainbowStamp("#ecf0f1"));
            StampPrototypeFactory.UpdatePrototype(7, new PeaceStamp("#95a5a6"));
            fw.PhotoBoothShoot(new int[] { 3, 4, 2, 1, 1, 1, 2, 3, 4, 5, 5, 6, 6, 7, 7, 0, 1, 4 });
            Console.WriteLine();
            Console.WriteLine();
            StampPrototypeFactory.UpdatePrototype(8, new GenericStamp(title: "Ring", render: "💍", color: "#95a5a6"));
            StampPrototypeFactory.UpdatePrototype(9, new GenericStamp(title: "Apple", render: "🍎", color: "#2980b9"));
            StampPrototypeFactory.UpdatePrototype(10, new GenericStamp(title: "Thunder", render: "⚡", color: "#ecf0f1"));
            StampPrototypeFactory.UpdatePrototype(11, new GenericStamp(title: "MusicNote", render: "🎵", color: "#95a5a6"));
            fw.PhotoBoothShoot(new int[] { 8, 9, 10, 11});
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}