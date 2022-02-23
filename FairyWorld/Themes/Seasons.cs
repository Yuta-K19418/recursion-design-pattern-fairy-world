using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Themes
{
    internal class Spring : ISpring
    {
        private Dictionary<int, MusicSong> musicSongDic;

        internal Spring()
        {
            musicSongDic = new Dictionary<int, MusicSong>()
            {
                {0, new MusicSong(
                    songTitle: "Sunshine",
                    lyrics: "Runnin’ through this strange life\r\n"
                        + "\tChasin’ all them green lights\r\n"
                        + "\tThrowin’ out the shade for a little bit of sunshine\r\n"
                        + "\tHit me with them good vibes\r\n"
                        + "\tPictures on my phone like\r\n"
                        + "\tEverything is so fine\r\n"
                        + "\tA little bit of sunshine ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 2,
                        seconds: 43
                        )
                    ) },
                {1, new MusicSong(
                    songTitle: "Save Your Tears",
                    lyrics: "I saw you dancing in a crowded room (Uh)\r\n"
                        + "\tYou look so happy when I'm not with you\r\n"
                        + "\tBut then you saw me, caught you by surprise\r\n"
                        + "\tA single teardrop falling from your eye ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 35
                        )
                    ) },
                {2, new MusicSong(
                    songTitle: "Shy Away",
                    lyrics: "When I get home\r\n"
                        + "\tYou better not be there\r\n"
                        + "\tWe're placin' bets you won't ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 2,
                        seconds: 55
                        )
                    ) },
            };
        }

        public string GetPoster()
        {
            return "Cherry blossoms and sunshine";
        }

        public string GetStringOfLights()
        {
            return "pink, purple, orange, blue, pink, purple, orange, blue";
        }

        public string LightShow()
        {
            return narration();
        }

        private string narration()
        {
            return "The warm spring sun shines softly";
        }


        public MusicSong GetMusicSong()
        {
            return musicSongDic[RandomWrapper.GetRanInt(2)];
        }

        public Mascot[] GetMascots()
        {
            return new Mascot[] {
                new Mascot(
                    name: "Sylvester the cat",
                    heightCm: 185,
                    widthCm: 100,
                    appearance: "cute",
                    person: new Person(
                            firstName: "Brayden",
                            lastName: "Anderson",
                            age: 18,
                            heightM: 183.1,
                            weightKg: 60,
                            biologicalSex: "male"
                        )
                ),
                new Mascot(
                    name: "Popeye",
                    heightCm: 180,
                    widthCm: 70,
                    appearance: "handsome",
                    person: new Person(
                            firstName: "Janai",
                            lastName: "Almeida",
                            age: 23,
                            heightM: 178.4,
                            weightKg: 57.5,
                            biologicalSex: "male"
                        )
                    )
            };
        }
    }

    internal class Summer : ISummer
    {
        private Dictionary<int, MusicSong> musicSongDic;

        internal Summer()
        {
            musicSongDic = new Dictionary<int, MusicSong>()
            {
                {0, new MusicSong(
                    songTitle: "Permission to Dance",
                    lyrics: "It's the thought of being young\r\n"
                        + "\tWhen your heart's just like a drum\r\n"
                        + "\tBeating louder with no way to guard it\r\n"
                        + "\tWhen it all seems like it's wrong\r\n"
                        + "\tJust sing along to Elton John\r\n"
                        + "\tAnd to that feeling, we're just getting started ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 7
                        )
                    ) },
                {1, new MusicSong(
                    songTitle: "Remember This",
                    lyrics: "Used to pray for a moment just like this\r\n"
                        + "\tThere's a fire in your eyes I can't resist\r\n"
                        + "\tBaby, we're gonna wanna remember this\r\n"
                        + "\tBaby, we're gonna wanna remember this\r\n"
                        + "\tI can taste the forever on your lips\r\n"
                        + "\tThere's a lifetime livin' inside that kiss\r\n"
                        + "\tBaby, we're gonna wanna remember this\r\n"
                        + "\tBaby, we're gonna wanna remember this ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 2,
                        seconds: 58
                        )
                    ) },
                {2, new MusicSong(
                    songTitle: "Skate",
                    lyrics: "In A Room Full Of Dimes\r\n"
                        + "\tYou Would Be A Hundred Dollars\r\n"
                        + "\tIf Being Fine Was A Crime\r\n"
                        + "\tGirl, They'd Lock Your Lil' Fine A$$ Up In A Tower\r\n"
                        + "\tThe Way You Move Like You Do\r\n"
                        + "\tOh! , It's Like You Do It For A Living\r\n"
                        + "\tDo A Lil' Spin, Do It Again\r\n"
                        + "\tSh!t, Look Like You Playing For The Win, Oh! Baby ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 23
                        )
                    ) },
            };
        }

        public string GetPoster()
        {
            return "The shining sunlight and the sea";
        }

        public string GetStringOfLights()
        {
            return "orange, red, yellow, blue, orange, red, yellow, blue";
        }

        public string LightShow()
        {
            return narration();
        }

        private string narration()
        {
            return "The light of the July sun shining like melted mercury";
        }

        public MusicSong GetMusicSong()
        {
            return musicSongDic[RandomWrapper.GetRanInt(2)];
        }

        public Mascot[] GetMascots()
        {
            return new Mascot[] {
                new Mascot(
                    name: "Jerry",
                    heightCm: 150,
                    widthCm: 80,
                    appearance: "small",
                    person: new Person(
                            firstName: "Noora",
                            lastName: "Molstad",
                            age: 28,
                            heightM: 150,
                            weightKg: 40,
                            biologicalSex: "female"
                        )
                ),
                new Mascot(
                    name: "Tom",
                    heightCm: 160,
                    widthCm: 70,
                    appearance: "good-looking",
                    person: new Person(
                            firstName: "Nathan",
                            lastName: "Wright",
                            age: 43,
                            heightM: 160.2,
                            weightKg: 53.1,
                            biologicalSex: "male"
                        )
                    )
            };
        }
    }

    internal class Autumn : IAutumn
    {
        private Dictionary<int, MusicSong> musicSongDic;

        internal Autumn()
        {
            musicSongDic = new Dictionary<int, MusicSong>()
            {
                {0, new MusicSong(
                    songTitle: "Overpass Graffiti",
                    lyrics: "This is a dark parade\r\n"
                        + "\tAnother rough patch to rain on, to rain on\r\n"
                        + "\tI know your friends may say\r\n"
                        + "\tThis is a cause for celebration, hip - hip - hooray, love\r\n"
                        + "\tPhotographs in sepia tones\r\n"
                        + "\tIt's so still, the fire's barely fighting the cold, alone\r\n"
                        + "\tThere are times when I can feel your ghost\r\n"
                        + "\tJust when I'm almost letting you go\r\n"
                        + "\tThe cards were stacked against us both ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 56
                        )
                    ) },
                {1, new MusicSong(
                    songTitle: "Ghost",
                    lyrics: "I miss your touch some nights when I'm hollow\r\n"
                        + "\tI know you crossed a bridge that I can't follow\r\n"
                        + "\tSince the love that you left is all that I get, I want you to know ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 2,
                        seconds: 33
                        )
                    ) },
                {2, new MusicSong(
                    songTitle: "Beautiful Mistakes",
                    lyrics: "It's beautiful, it's bittersweet\r\n"
                        + "\tYou're like a broken home to me\r\n"
                        + "\tI take a shot of memories\r\n"
                        + "\tAnd black out like an empty street\r\n"
                        + "\tI fill my days with the way you walk\r\n"
                        + "\tAnd fill my nights with broken dreams\r\n"
                        + "\tI make up lies inside my head\r\n"
                        + "\tLike one day you'll come back to me ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 47
                        )
                    ) },
            };
        }

        public string GetPoster()
        {
            return "Fallen leaves";
        }

        public string GetStringOfLights()
        {
            return "red, brown, beige, yellow, red, brown, beige, yellow";
        }

        public string LightShow()
        {
            return narration();
        }

        private string narration()
        {
            return "The moonlight shining brightly in the sky";
        }

        public MusicSong GetMusicSong()
        {
            return musicSongDic[RandomWrapper.GetRanInt(2)];
        }

        public Mascot[] GetMascots()
        {
            return new Mascot[] {
                new Mascot(
                    name: "Genie",
                    heightCm: 190,
                    widthCm: 120,
                    appearance: "big!",
                    person: new Person(
                            firstName: "Phillip",
                            lastName: "Perez",
                            age: 31,
                            heightM: 188,
                            weightKg: 78,
                            biologicalSex: "male"
                        )
                ),
                new Mascot(
                    name: "Wile E. Coyote",
                    heightCm: 170,
                    widthCm: 90,
                    appearance: "Looks weak",
                    person: new Person(
                            firstName: "Scarlett",
                            lastName: "Gray",
                            age: 23,
                            heightM: 169.4,
                            weightKg: 57.8,
                            biologicalSex: "female"
                        )
                    )
            };
        }
    }


    internal class Winter : IWinter
    {
        private Dictionary<int, MusicSong> musicSongDic;

        internal Winter()
        {
            musicSongDic = new Dictionary<int, MusicSong>()
            {
                {0, new MusicSong(
                    songTitle: "Easy On Me",
                    lyrics: "There ain't no gold in this river\r\n"
                        + "\tThat I've been washin' my hands in forever\r\n"
                        + "\tI know there is hope in these waters\r\n"
                        + "\tBut I can't bring myself to swim\r\n"
                        + "\tWhen I am drowning in this silence\r\n"
                        + "\tBaby, let me in ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 44
                        )
                    ) },
                {1, new MusicSong(
                    songTitle: "Soft Landing",
                    lyrics: "For a second the dysfunction felt romantic\r\n"
                        + "\tThree years in and I can’t stand it\r\n"
                        + "\tFell for your mystery, your reckless abandon\r\n"
                        + "\tNow I’d prefer you’d just be candid ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 2,
                        seconds: 27
                        )
                    ) },
                {2, new MusicSong(
                    songTitle: "A Temporary High",
                    lyrics: "It seems like we\r\n"
                        + "\tLike to be living dangerously\r\n"
                        + "\tOur heart sings a temporary lie\r\n"
                        + "\tIt seems like her\r\n"
                        + "\tMadness could be endlessly\r\n"
                        + "\tHer love is a temporary high ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 23
                        )
                    ) },
            };
        }
        public string GetPoster()
        {
            return "Snowman and Santa Claus";
        }

        public string GetStringOfLights()
        {
            return "green, red, green, red, green, red, green, red";
        }

        public string LightShow()
        {
            return narration();
        }

        private string narration()
        {
            return "The fragile and fragile sunlight of November approaching the winter tide";
        }

        public MusicSong GetMusicSong()
        {
            return musicSongDic[RandomWrapper.GetRanInt(2)];
        }

        public Mascot[] GetMascots()
        {
            return new Mascot[] {
                new Mascot(
                    name: "Toothless",
                    heightCm: 145,
                    widthCm: 60,
                    appearance: "unique",
                    person: new Person(
                            firstName: "Tracy",
                            lastName: "Lee",
                            age: 45,
                            heightM: 140,
                            weightKg: 39,
                            biologicalSex: "female"
                        )
                ),
                new Mascot(
                    name: "Hiccup",
                    heightCm: 160,
                    widthCm: 60,
                    appearance: "lovely",
                    person: new Person(
                            firstName: "Andréia",
                            lastName: "Nunes",
                            age: 26,
                            heightM: 154.6,
                            weightKg: 42,
                            biologicalSex: "female"
                        )
                    )
            };
        }
    }

    internal class Halloween : IHalloween
    {
        private Dictionary<int, MusicSong> musicSongDic;

        internal Halloween()
        {
            musicSongDic = new Dictionary<int, MusicSong>() {
                {0, new MusicSong(
                    songTitle: "Thriller",
                    lyrics: "It's close to midnight\r\n"
                         + "\tSomething evil's lurking in the dark\r\n"
                         + "\tUnder the moonlight\r\n"
                         + "\tYou see a sight that almost stops your heart\r\n"
                         + "\tYou try to scream\r\n"
                         + "\tBut terror takes the sound before you make it\r\n"
                         + "\tYou start to freeze\r\n"
                         + "\tAs horror looks you right between the eyes\r\n"
                         + "\tYou're paralyzed ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 5,
                        seconds: 58
                        )
                    ) },
                {1, new MusicSong(
                    songTitle: "bad guy",
                    lyrics: "White shirt now red, my bloody nose\r\n"
                         + "\tSleepin', you're on your tippy toes\r\n"
                         + "\tCreepin' around like no one knows\r\n"
                         + "\tThink you're so criminal\r\n"
                         + "\tBruises on both my knees for you\r\n"
                         + "\tDon't say thank you or please\r\n"
                         + "\tI do what I want when I'm wanting to\r\n"
                         + "\tMy soul? So cynical ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 14
                        )
                    ) },
                {2, new MusicSong(
                    songTitle: "Monster",
                    lyrics: "Don't call me GaGa\r\n"
                        + "\tI've never seen one like that before\r\n"
                        + "\tDon't look at me like that\r\n"
                        + "\tYou amaze me ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 4,
                        seconds: 9
                        )
                    ) },
            };
        }

        public string GetPoster()
        {
            return "Pumpkin and sweets";
        }

        public string GetStringOfLights()
        {
            return "orange, purple, black, yellow, orange, purple, black, yellow";
        }

        public string LightShow()
        {
            return narration();
        }

        private string narration()
        {
            return "Creepy light that monsters are likely to come out";
        }

        public MusicSong GetMusicSong()
        {
            return musicSongDic[RandomWrapper.GetRanInt(2)];
        }

        public Mascot[] GetMascots()
        {
            return new Mascot[] {
                new Mascot(
                    name: "Jack frost",
                    heightCm: 162,
                    widthCm: 70,
                    appearance: "attractive",
                    person: new Person(
                            firstName: "Daniel",
                            lastName: "Jørgensen",
                            age: 33,
                            heightM: 160,
                            weightKg: 50,
                            biologicalSex: "male"
                        )
                ),
            };
        }
    }

    internal class Valentine : IValentine
    {
        private Dictionary<int, MusicSong> musicSongDic;

        internal Valentine()
        {
            musicSongDic = new Dictionary<int, MusicSong>() {
                {0, new MusicSong(
                    songTitle: "The Joker And The Queen",
                    lyrics: "How was I to know? It's a crazy thing\r\n"
                        + "\tI showed you my hand and you still let me win\r\n"
                        + "\tAnd who was I to say that this was meant to be?\r\n"
                        + "\tThe road that was broken brought us together ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 5
                        )
                    ) },
                {1, new MusicSong(
                    songTitle: "Love Story",
                    lyrics: "We were both young when I first saw you\r\n"
                        + "\tI close my eyes, and the flashback starts\r\n"
                        + "\tI'm standing there\r\n"
                        + "\tOn a balcony in summer air\r\n"
                        + "\tSee the lights, see the party, the ball gowns\r\n"
                        + "\tSee you make your way through the crowd\r\n"
                        + "\tAnd say, \"Hello\"\r\n"
                        + "\tLittle did I know ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 3,
                        seconds: 55
                        )
                    ) },
                {2, new MusicSong(
                    songTitle: "10,000 Hours",
                    lyrics: "Do you love the rain, does it make you dance\r\n"
                         + "\tWhen you're drunk with your friends at a party?\r\n"
                         + "\tWhat's your favorite song, does it make you smile?\r\n"
                         + "\tDo you think of me? ~ ",
                    songLength: new TimeSpan(
                        hours: 0,
                        minutes: 2,
                        seconds: 47
                        )
                    ) },
            };
        }

        public string GetPoster()
        {
            return "Rose flowers and chocolate";
        }

        public string GetStringOfLights()
        {
            return "bordeaux, beige gray, rose gray, black, bordeaux, beige gray, rose gray, black";
        }

        public string LightShow()
        {
            return narration();
        }

        private string narration()
        {
            return "A gentle, soft and bright light full of love";
        }

        public MusicSong GetMusicSong()
        {
            return musicSongDic[RandomWrapper.GetRanInt(2)];
        }

        public Mascot[] GetMascots()
        {
            return new Mascot[] {
                new Mascot(
                    name: "Po",
                    heightCm: 170,
                    widthCm: 80,
                    appearance: "charming",
                    person: new Person(
                            firstName: "Arlene",
                            lastName: "Castro",
                            age: 24,
                            heightM: 167.6,
                            weightKg: 53.1,
                            biologicalSex: "female"
                        )
                ),
            };
        }
    }
}
