using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.ToyKits
{
    internal class HumanoidToyKitHead : IHumanoidToyKitHead
    {
        private int eyes;
        private int ears;
        private bool hasNose;
        private bool hasMouth;
        private bool hasPartsBeenCreated;

        internal HumanoidToyKitHead()
        {
            this.eyes = 0;
            this.ears = 0;
            this.hasNose = false;
            this.hasMouth = false;
            this.hasPartsBeenCreated = false;
        }

        public void CreateHead()
        {
            this.eyes = 2;
            this.ears = 2;
            this.hasNose = true;
            this.hasMouth = true;
        }

        public void CreateEye()
        {
            this.eyes++;
            this.hasPartsBeenCreated = true;
        }

        public void CreateEars()
        {
            this.ears++;
            this.hasPartsBeenCreated = true;
        }

        public void CreateNose()
        {
            this.hasNose = true;
            this.hasPartsBeenCreated = true;
        }

        public void CreateMouth()
        {
            this.hasMouth = true;
            this.hasPartsBeenCreated = true;
        }

        public int GetLevels()
        {
            var value = RandomWrapper.GetRanInt(5);
            return value == 0 ? 1 : value;
        }

        public int GetCosts()
        {
            var value = RandomWrapper.GetRanInt(10);
            return value == 0 ? 1 : value;
        }
    }

    internal class HumanoidToyKitBody : IHumanoidToyKitBody
    {
        private bool hasBody;

        internal HumanoidToyKitBody()
        {
            this.hasBody = false;
        }

        public void CreateBody()
        {
            this.hasBody = true;
        }

        public int GetLevels()
        {
            var value = RandomWrapper.GetRanInt(5);
            return value == 0 ? 1 : value;
        }

        public int GetCosts()
        {
            var value = RandomWrapper.GetRanInt(10);
            return value == 0 ? 1 : value;
        }
    }

    internal class HumanoidToyKitRightArm : IHumanoidToyKitRightArm
    {
        private int arm;
        private int hand;

        internal HumanoidToyKitRightArm()
        {
            this.arm = 0;
            this.hand = 0;
        }

        public void CreateRightArm()
        {
            this.arm++;
            this.hand++;
        }

        public void CreateRightHand()
        {
            this.hand++;
        }

        public int GetLevels()
        {
            var value = RandomWrapper.GetRanInt(5);
            return value == 0 ? 1 : value;
        }

        public int GetCosts()
        {
            var value = RandomWrapper.GetRanInt(10);
            return value == 0 ? 1 : value;
        }
    }

    internal class HumanoidToyKitLeftArm : IHumanoidToyKitLeftArm
    {
        private int arm;
        private int hand;

        internal HumanoidToyKitLeftArm()
        {
            this.arm = 0;
            this.hand = 0;
        }

        public void CreateLeftArm()
        {
            this.arm++;
            this.hand++;
        }

        public void CreateLeftHand()
        {
            this.hand++;
        }

        public int GetLevels()
        {
            var value = RandomWrapper.GetRanInt(5);
            return value == 0 ? 1 : value;
        }

        public int GetCosts()
        {
            var value = RandomWrapper.GetRanInt(10);
            return value == 0 ? 1 : value;
        }
    }

    internal class HumanoidToyKitRightLeg : IHumanoidToyKitRightLeg
    {
        private int leg;
        private int foot;

        internal HumanoidToyKitRightLeg()
        {
            this.leg = 0;
            this.foot = 0;
        }

        public void CreateRightLeg()
        {
            this.leg++;
            this.foot++;
        }

        public void CreateRightFoot()
        {
            this.foot++;
        }

        public int GetLevels()
        {
            var value = RandomWrapper.GetRanInt(5);
            return value == 0 ? 1 : value;
        }

        public int GetCosts()
        {
            var value = RandomWrapper.GetRanInt(10);
            return value == 0 ? 1 : value;
        }
    }

    internal class HumanoidToyKitLeftLeg : IHumanoidToyKitLeftLeg
    {
        private int leg;
        private int foot;

        internal HumanoidToyKitLeftLeg()
        {
            this.leg = 0;
            this.foot = 0;
        }

        public void CreateLeftLeg()
        {
            this.leg++;
            this.foot++;
        }

        public void CreateLeftFoot()
        {
            this.foot++;
        }

        public int GetLevels()
        {
            var value = RandomWrapper.GetRanInt(5);
            return value == 0 ? 1 : value;
        }

        public int GetCosts()
        {
            var value = RandomWrapper.GetRanInt(10);
            return value == 0 ? 1 : value;
        }
    }
}
