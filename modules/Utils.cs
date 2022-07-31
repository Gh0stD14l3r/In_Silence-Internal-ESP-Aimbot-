using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Photon.Pun;

namespace In_Silence.modules
{
    class Utils
    {
        public static string GetArmoryKeyCode()
        {
            UI.ArmoryKeycode = "";
            if (game_objects.in_silence.puzzleCabin != null)
            {
                foreach (PuzzleKey i in game_objects.in_silence.puzzleCabin.keys)
                {
                    UI.ArmoryKeycode = UI.ArmoryKeycode + i.targetNumber;
                }

                return UI.ArmoryKeycode;
            }
            
            return "";
        }

        public static void SetGameHost()
        {
            if (!PhotonNetwork.IsMasterClient)
            {
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            }
        }
    }
}
