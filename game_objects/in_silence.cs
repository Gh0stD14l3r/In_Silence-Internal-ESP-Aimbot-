using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Silence.game_objects
{
    class in_silence
    {
        public static WorldManager World = UnityEngine.GameObject.FindObjectOfType<WorldManager>();
        public static TruckManager Vehicle = UnityEngine.GameObject.FindObjectOfType<TruckManager>();
        public static ArmoryDoor Armory = UnityEngine.GameObject.FindObjectOfType<ArmoryDoor>();
        public static PuzzleCabin puzzleCabin = UnityEngine.GameObject.FindObjectOfType<PuzzleCabin>();
        public static FlashbangManager Flashbang = UnityEngine.GameObject.FindObjectOfType<FlashbangManager>();


        public static void update()
        {
            World = UnityEngine.GameObject.FindObjectOfType<WorldManager>();
            Vehicle = UnityEngine.GameObject.FindObjectOfType<TruckManager>();
            puzzleCabin = UnityEngine.GameObject.FindObjectOfType<PuzzleCabin>();
            Flashbang = UnityEngine.GameObject.FindObjectOfType<FlashbangManager>();

            Hacks.eItem = UnityEngine.GameObject.FindObjectsOfType<Item>().ToList();
            Hacks.eActivableItem = UnityEngine.GameObject.FindObjectsOfType<ActivableItem>().ToList();
            Hacks.eArmoryDoor = UnityEngine.GameObject.FindObjectsOfType<ArmoryDoor>().ToList();
            Hacks.eBearTrap = UnityEngine.GameObject.FindObjectsOfType<BearTrap>().ToList();
            Hacks.eCrow = UnityEngine.GameObject.FindObjectsOfType<Crow>().ToList();
            Hacks.eCrowFlock = UnityEngine.GameObject.FindObjectsOfType<CrowFlock>().ToList();
            Hacks.eDeadBodies = UnityEngine.GameObject.FindObjectsOfType<DeadBodyController>().ToList();
            Hacks.eDogHouse = UnityEngine.GameObject.FindObjectsOfType<DogHouse>().ToList();
            Hacks.eGroundItem = UnityEngine.GameObject.FindObjectsOfType<GroundItem>().ToList();
            Hacks.eJackInBox = UnityEngine.GameObject.FindObjectsOfType<JackInBox>().ToList();
            Hacks.ePlayableCharacter = UnityEngine.GameObject.FindObjectsOfType<SurvivorNetworking>().ToList();
            Hacks.ePuzzleButton = UnityEngine.GameObject.FindObjectsOfType<PuzzleButton>().ToList();
            Hacks.ePuzzleCabin = UnityEngine.GameObject.FindObjectsOfType<PuzzleCabin>().ToList();
            Hacks.ePuzzleKey = UnityEngine.GameObject.FindObjectsOfType<PuzzleKey>().ToList();
            Hacks.ePuzzleTablet = UnityEngine.GameObject.FindObjectsOfType<PuzzleTablet>().ToList();
            Hacks.eRadio = UnityEngine.GameObject.FindObjectsOfType<Radio>().ToList();
            Hacks.eRabbitController = UnityEngine.GameObject.FindObjectsOfType<RabbitController>().ToList();
            Hacks.eRifle = UnityEngine.GameObject.FindObjectsOfType<Rifle>().ToList();
            Hacks.eRifleItem = UnityEngine.GameObject.FindObjectsOfType<RifleItem>().ToList();
            Hacks.eRocket = UnityEngine.GameObject.FindObjectsOfType<Rocket>().ToList();
            Hacks.eStone = UnityEngine.GameObject.FindObjectsOfType<Stone>().ToList();
            Hacks.eToy = UnityEngine.GameObject.FindObjectsOfType<Toy>().ToList();
            Hacks.eTruckPart = UnityEngine.GameObject.FindObjectsOfType<TruckPart>().ToList();
            Hacks.eWitch = UnityEngine.GameObject.FindObjectsOfType<Witch>().ToList();
            Hacks.eTelevision = UnityEngine.GameObject.FindObjectsOfType<Television>().ToList();
            Hacks.eCreature = UnityEngine.GameObject.FindObjectsOfType<CreatureAIManager>().ToList();
            Hacks.eBodyPlayer = UnityEngine.GameObject.FindObjectsOfType<PlayableCharacter>().ToList();

            if (Hacks.localPlayer == null)
            {
                foreach (SurvivorNetworking entity in Hacks.ePlayableCharacter)
                {
                    if (entity != null && entity.photonView.IsMine)
                    {
                        Hacks.localPlayer = entity;
                    }
                }
            }
        }
    }
}
