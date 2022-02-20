using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.ToyKits
{
    internal class Robot : HumanoidToyKit, IRobot
    {
        internal Robot(string toyName)
            : base(toyName)
        {

        }

        public override void MakeNoise()
        {
            ExecuteWhenTrue(() => Console.WriteLine("MakeNoise: pip pip pip"));
        }

        public override void Walk()
        {
            ExecuteWhenTrue(() => Console.WriteLine("Walk: thud thud thud"));
        }
    }

    internal class Vampire : HumanoidToyKit, IVampire
    {
        internal Vampire(string toyName)
            : base(toyName)
        {

        }

        public override void MakeNoise()
        {
            ExecuteWhenTrue(() => Console.WriteLine("MakeNoise: squash squash squash"));
        }

        public override void Walk()
        {
            ExecuteWhenTrue(() => Console.WriteLine("Walk: slurp slurp slurp"));
        }
    }

    internal class Werewolf : HumanoidToyKit, IWerewolf
    {
        internal Werewolf(string toyName)
            : base(toyName)
        {

        }

        public override void MakeNoise()
        {
            ExecuteWhenTrue(() => Console.WriteLine("MakeNoise: awoo awoo awoo"));
        }

        public override void Walk()
        {
            ExecuteWhenTrue(() => Console.WriteLine("Walk: pow pow pow"));
        }
    }

    internal class Transformer : HumanoidToyKit, ITransformer
    {
        internal Transformer(string toyName)
            : base(toyName)
        {

        }

        public override void MakeNoise()
        {
            ExecuteWhenTrue(() => Console.WriteLine("MakeNoise: beeow beeow beeow"));
        }

        public override void Walk()
        {
            ExecuteWhenTrue(() => Console.WriteLine("Walk: zap zap zap"));
        }
    }

    internal class Alien : HumanoidToyKit, IAlien
    {
        internal Alien(string toyName)
            : base(toyName)
        {

        }

        public override void MakeNoise()
        {
            ExecuteWhenTrue(() => Console.WriteLine("MakeNoise: pon pon pon"));
        }

        public override void Walk()
        {
            ExecuteWhenTrue(() => Console.WriteLine("Walk: ba-dump ba-dump ba-dump"));
        }
    }
}
