using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.ToyKits
{
    internal class HumanoidToyKitFactory : IHumanoidToyKitFactory
    {
        public IRobot CreateRobot()
        {
            var robot = new Robot("Robot");
            robot.CreateHead()
                .CreateBody()
                .CreateRightArm()
                .CreateLeftArm()
                .CreateRightLeg()
                .CreateLeftLeg()
                .AddMicroChip()
                .AddCircuitBoard()
                .AddBattery();
            return robot;
        }

        public IVampire CreateVampire()
        {
            var vampire= new Vampire("Vampire");
            vampire.CreateHead()
                .CreateBody()
                .CreateRightArm()
                .CreateLeftArm()
                .CreateRightLeg()
                .CreateLeftLeg()
                .AddCircuitBoard()
                .AddBattery();
            return vampire;
        }

        public IWerewolf CreateWerewolf()
        {
            var werewolf = new Werewolf("Werewolf");
            werewolf.CreateHead()
                .CreateBody()
                .CreateRightArm()
                .CreateLeftArm()
                .CreateRightLeg()
                .CreateLeftLeg()
                .AddBattery();
            return werewolf;
        }

        public ITransformer CreateTransformer()
        {
            var transformer = new Transformer("Transformer");
            transformer.CreateHead()
                .CreateBody()
                .CreateRightArm()
                .CreateLeftArm()
                .CreateRightLeg()
                .CreateLeftLeg();
            return transformer;
        }

        public IAlien CreateAlien()
        {
            var alien = new Alien("Alien");
            alien.CreateHead()
                .CreateBody()
                .CreateRightArm()
                .CreateLeftArm()
                .CreateRightLeg()
                .CreateLeftLeg();
            return alien;
        }

    }
}
