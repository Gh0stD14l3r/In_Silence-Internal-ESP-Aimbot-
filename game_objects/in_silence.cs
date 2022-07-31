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
            //Armory = UnityEngine.GameObject.FindObjectOfType<ArmoryDoor>();
            puzzleCabin = UnityEngine.GameObject.FindObjectOfType<PuzzleCabin>();
            Flashbang = UnityEngine.GameObject.FindObjectOfType<FlashbangManager>();
        }
    }
}
