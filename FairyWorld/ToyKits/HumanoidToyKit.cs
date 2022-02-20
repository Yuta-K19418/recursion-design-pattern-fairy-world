using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.ToyKits
{
    internal abstract class HumanoidToyKit : IHumanoidToyKit
    {
        private string toyName;
        private IHumanoidToyKitHead head;
        private IHumanoidToyKitBody body;
        private IHumanoidToyKitRightArm rightArm;
        private IHumanoidToyKitLeftArm leftArm;
        private IHumanoidToyKitRightLeg rightLeg;
        private IHumanoidToyKitLeftLeg leftLeg;
        private bool hasMicroChip;
        private bool hasCircuitBoard;
        private bool hasBattery;
        private bool isHeadAssembled;
        private bool isEyesAssembled;
        private bool isEarsAssembled;
        private bool isNoseAssembled;
        private bool isMouthAssembled;
        private bool isBodyAssembled;
        private bool isRightArmAssembled;
        private bool isLeftArmAssembled;
        private bool isRightLegAssembled;
        private bool isLeftLegAssembled;
        private int headAssemblyLevel;
        private int bodyAssemblyLevel;
        private int rightArmAssemblyLevel;
        private int leftArmAssemblyLevel;
        private int rightLegAssemblyLevel;
        private int leftLegAssemblyLevel;

        internal HumanoidToyKit(string toyName)
        {
            this.toyName = toyName;
            this.head = new HumanoidToyKitHead();
            this.body = new HumanoidToyKitBody();
            this.rightArm = new HumanoidToyKitRightArm();
            this.leftArm = new HumanoidToyKitLeftArm();
            this.rightLeg = new HumanoidToyKitRightLeg();
            this.leftLeg = new HumanoidToyKitLeftLeg();
            this.hasMicroChip = false;
            this.hasCircuitBoard = false;
            this.hasBattery = false;
            this.isHeadAssembled = false;
            this.isEyesAssembled = false;
            this.isEarsAssembled = false;
            this.isNoseAssembled = false;
            this.isMouthAssembled = false;
            this.isBodyAssembled = false;
            this.isRightArmAssembled = false;
            this.isLeftArmAssembled = false;
            this.isRightLegAssembled = false;
            this.isLeftLegAssembled = false;
            this.headAssemblyLevel = head.GetLevels();
            this.bodyAssemblyLevel = body.GetLevels();
            this.rightArmAssemblyLevel = rightArm.GetLevels();
            this.leftArmAssemblyLevel = leftArm.GetLevels();
            this.rightLegAssemblyLevel = rightLeg.GetLevels();
            this.leftLegAssemblyLevel = leftLeg.GetLevels();
        }

        public virtual IHumanoidToyKit CreateHead()
        {
            head.CreateHead();
            this.isHeadAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateEye()
        {
            head.CreateEye();
            this.isEyesAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateEars()
        {
            head.CreateEars();
            this.isEarsAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateNose()
        {
            head.CreateNose();
            this.isNoseAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateMouth()
        {
            head.CreateMouth();
            this.isMouthAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateBody()
        {
            body.CreateBody();
            this.isBodyAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateRightArm()
        {
            rightArm.CreateRightArm();
            this.isRightArmAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateRightHand()
        {
            rightArm.CreateRightHand();
            return this;
        }

        public virtual IHumanoidToyKit CreateLeftArm()
        {
            leftArm.CreateLeftArm();
            this.isLeftArmAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateLeftHand()
        {
            leftArm.CreateLeftHand();
            return this;
        }

        public virtual IHumanoidToyKit CreateRightLeg()
        {
            rightLeg.CreateRightLeg();
            this.isRightLegAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateRightFoot()
        {
            rightLeg.CreateRightFoot();
            return this;
        }

        public virtual IHumanoidToyKit CreateLeftLeg()
        {
            leftLeg.CreateLeftLeg();
            this.isLeftLegAssembled = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit CreateLeftFoot()
        {
            leftLeg.CreateLeftFoot();
            return this;
        }

        public virtual IHumanoidToyKit AddMicroChip()
        {
            this.hasMicroChip = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit AddCircuitBoard()
        {
            this.hasCircuitBoard = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual IHumanoidToyKit AddBattery()
        {
            this.hasBattery = true;
            BillCostWhenCompleted();
            return this;
        }

        public virtual void DisplayAssemblyLevel()
        {
            Console.WriteLine();
            Console.WriteLine("==================================");
            Console.WriteLine($"ToyKit: {this.toyName}");
            Console.WriteLine($"Head Assembly Level: {this.headAssemblyLevel} / 5");
            Console.WriteLine($"Body Assembly Level: {this.bodyAssemblyLevel} / 5");
            Console.WriteLine($"Right Arm Assembly Level: {this.rightArmAssemblyLevel} / 5");
            Console.WriteLine($"Left Arm Assembly Level: {this.leftArmAssemblyLevel} / 5");
            Console.WriteLine($"Right Leg Assembly Level: {this.rightLegAssemblyLevel} / 5");
            Console.WriteLine($"Left Leg Assembly Level: {this.leftLegAssemblyLevel} / 5");
            var total = this.headAssemblyLevel
                + this.bodyAssemblyLevel
                + this.rightArmAssemblyLevel
                + this.leftArmAssemblyLevel
                + this.rightLegAssemblyLevel
                + this.leftLegAssemblyLevel;
            Console.WriteLine($"Total Level: {total} / 30");
            Console.WriteLine();

            switch (total)
            {
                case int level when 10 > level:
                    Console.WriteLine("All ages: very easy!");
                    break;
                case int level when 20 > level:
                    Console.WriteLine("1 - 5 year-old: a little easy!");
                    Console.WriteLine("6 years and over: very easy!");
                    break;
                case int level when 30 >= level:
                    Console.WriteLine("1 - 5 year-old: Need parental help!");
                    Console.WriteLine("6 years and over: It can be assembled by one person, but be careful!");
                    break;
                default:
                    throw new NotImplementedException();
            }
            Console.WriteLine("==================================");
            Console.WriteLine();
        }

        protected virtual void ExecuteWhenTrue(Action action)
        {
            if (hasMicroChip && hasCircuitBoard && hasBattery)
            {
                action();
            }
            else
            {
                var sb = new StringBuilder("You have to set ");

                if (!hasMicroChip)
                {
                    sb.Append("MIcroChip, ");
                }

                if (!hasCircuitBoard)
                {
                    sb.Append("CircuitBoard, ");
                }

                if (!hasBattery)
                {
                    sb.Append("Battery, ");
                }

                Console.WriteLine(sb.ToString().TrimEnd(' ').TrimEnd(',') + "!");
            }
        }

        public abstract void MakeNoise();

        public abstract void Walk();

        private void BillCostWhenCompleted()
        {
            if ((isHeadAssembled
                    || (isEyesAssembled
                        && isEarsAssembled
                        && isNoseAssembled
                        && isMouthAssembled))
                    && isBodyAssembled
                    && isRightArmAssembled
                    && isLeftArmAssembled
                    && isRightLegAssembled
                    && isLeftLegAssembled
                    && hasMicroChip
                    && hasCircuitBoard
                    && hasBattery)
            {
                var total = head.GetCosts()
                    + body.GetCosts()
                    + rightArm.GetCosts()
                    + leftArm.GetCosts()
                    + rightLeg.GetCosts()
                    + leftLeg.GetCosts();
                Console.WriteLine($"The cost of \"{toyName}\" is $ {total}.");
            }
        }

    }
}
