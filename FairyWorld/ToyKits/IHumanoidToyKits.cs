using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.ToyKits
{
    internal interface IHumanoidToyKit
    {
        public IHumanoidToyKit CreateHead();

        public IHumanoidToyKit CreateEye();

        public IHumanoidToyKit CreateEars();

        public IHumanoidToyKit CreateNose();

        public IHumanoidToyKit CreateMouth();

        public IHumanoidToyKit CreateBody();

        public IHumanoidToyKit CreateRightArm();

        public IHumanoidToyKit CreateRightHand();

        public IHumanoidToyKit CreateLeftArm();

        public IHumanoidToyKit CreateLeftHand();

        public IHumanoidToyKit CreateRightLeg();

        public IHumanoidToyKit CreateRightFoot();

        public IHumanoidToyKit CreateLeftLeg();

        public IHumanoidToyKit CreateLeftFoot();

        public IHumanoidToyKit AddMicroChip();

        public IHumanoidToyKit AddCircuitBoard();

        public IHumanoidToyKit AddBattery();

        public void DisplayAssemblyLevel();

        public void MakeNoise();

        public void Walk();
    }

    internal interface IRobot : IHumanoidToyKit
    {
    }

    internal interface IVampire : IHumanoidToyKit
    {
    }

    internal interface IWerewolf : IHumanoidToyKit
    {
    }

    internal interface ITransformer : IHumanoidToyKit
    {
    }

    internal interface IAlien : IHumanoidToyKit
    {
    }
}
