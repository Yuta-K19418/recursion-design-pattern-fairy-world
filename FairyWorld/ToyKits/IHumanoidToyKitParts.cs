using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.ToyKits
{
    internal interface IHumanoidToyKitHead : IProduct
    {
        public void CreateHead();

        public void CreateEye();

        public void  CreateEars();

        public void CreateNose();

        public void CreateMouth();
    }

    internal interface IHumanoidToyKitBody : IProduct
    {
        public void CreateBody();
    }

    internal interface IHumanoidToyKitRightArm : IProduct
    {
        public void CreateRightArm();

        public void CreateRightHand();
    }

    internal interface IHumanoidToyKitLeftArm : IProduct
    {
        public void CreateLeftArm();

        public void CreateLeftHand();
    }

    internal interface IHumanoidToyKitRightLeg : IProduct
    {
        public void CreateRightLeg();
        public void CreateRightFoot();
    }

    internal interface IHumanoidToyKitLeftLeg : IProduct
    {
        public void CreateLeftLeg();
        public void CreateLeftFoot();
    }
}
