using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

namespace In_Silence.modules
{
    class UI
    {
        public static Rect MainMenu = new Rect(5f, 5f, 230f, 168f);
        public static Rect ESPMenu = new Rect(5f, 5f, 300f, 123f);
        public static Rect GameInfoMenu = new Rect(5f, 5f, 330f, 200f);
        public static Rect PlayerMenu = new Rect(5f, 5f, 460f, 210f);

        public static bool esp_menu = false;
        public static bool gameinfo_menu = false;
        public static bool player_menu = false;
        public static bool main_menu = true;

        public static bool toggleESPCreature = false;
        public static bool toggleESPPlayer = false;
        public static bool toggleESPItem = false;
        public static bool toggleESPAlertItem = false;
        public static bool toggleESPVehicle = false;
        public static bool toggleAimbot = false;

        public static bool t_ESPCreature = false;
        public static bool t_ESPPlayer = false;
        public static bool t_ESPItem = false;
        public static bool t_ESPAlertItem = false;
        public static bool t_ESPVehicle = false;
        public static bool t_Aimbot = false;

        public static bool t_menuesp = false;
        public static bool t_menuplayer = false;
        public static bool t_menuinfo = false;
        public static bool t_menucontrol = false;

        public static bool t_menu_esp = false;
        public static bool t_menu_player = false;
        public static bool t_menu_info = false;
        public static bool t_menu_control = false;

        public static string ArmoryKeycode = "";
        public static string v_type;

        public static void displayUI()
        {
            if (modules.UI.main_menu)
            {
                modules.UI.MainMenu = GUI.Window(4, modules.UI.MainMenu, modules.UI.MainWindow, "In Silence - Main Menu - Gh0st");
            }
            if (modules.UI.esp_menu)
            {
                modules.UI.ESPMenu = GUI.Window(0, modules.UI.ESPMenu, modules.UI.ESPWindow, "In Silence - ESP Menu - Gh0st");
            }
            if (modules.UI.gameinfo_menu)
            {
                modules.UI.GameInfoMenu = GUI.Window(1, modules.UI.GameInfoMenu, modules.UI.GameInfoWindow, "In Silence - Info Menu - Gh0st");
            }
            if (modules.UI.player_menu)
            {
                modules.UI.PlayerMenu = GUI.Window(3, modules.UI.PlayerMenu, modules.UI.PlayerWindow, "In Silence - Player Menu - Gh0st");
            }
        }


        public static void ESPWindow(int windowID)
        {
            modules.UI.toggleESPCreature = GUI.Toggle(new Rect(10f, 20f, 121f, 20f), modules.UI.t_ESPCreature, "Creature ESP");
            if (modules.UI.toggleESPCreature != modules.UI.t_ESPCreature)
            {
                modules.UI.t_ESPCreature = !modules.UI.t_ESPCreature;
            }
            modules.UI.toggleESPPlayer = GUI.Toggle(new Rect(136f, 20f, 121f, 20f), modules.UI.t_ESPPlayer, "Player ESP");
            if (modules.UI.toggleESPPlayer != modules.UI.t_ESPPlayer)
            {
                modules.UI.t_ESPPlayer = !modules.UI.t_ESPPlayer;
            }
            modules.UI.toggleESPItem = GUI.Toggle(new Rect(10f, 45f, 121f, 20f), modules.UI.t_ESPItem, "Item ESP");
            if (modules.UI.toggleESPItem != modules.UI.t_ESPItem)
            {
                modules.UI.t_ESPItem = !modules.UI.t_ESPItem;
            }
            modules.UI.toggleESPAlertItem = GUI.Toggle(new Rect(136f, 45f, 121f, 20f), modules.UI.t_ESPAlertItem, "Alert Item ESP");
            if (modules.UI.toggleESPAlertItem != modules.UI.t_ESPAlertItem)
            {
                modules.UI.t_ESPAlertItem = !modules.UI.t_ESPAlertItem;
            }
            modules.UI.toggleESPVehicle = GUI.Toggle(new Rect(10f, 70f, 121f, 20f), modules.UI.t_ESPVehicle, "Vehicle ESP");
            if (modules.UI.toggleESPVehicle != modules.UI.t_ESPVehicle)
            {
                modules.UI.t_ESPVehicle = !modules.UI.t_ESPVehicle;
            }

            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void GameInfoWindow(int windowID)
        {
            if (game_objects.in_silence.Vehicle != null)
            {
                if (game_objects.in_silence.Vehicle.isHelicopter) { v_type = "Helicopter"; } else { v_type = "Car"; }
                GUI.Label(new Rect(10f, 20f, 307f, 25f), $"Vehicle Type: {v_type}");

                GUI.Label(new Rect(10f, 45f, 145f, 25f), $"Wheels: {game_objects.in_silence.Vehicle.need_wheelCount}");
                GUI.Label(new Rect(10f, 70f, 145f, 25f), $"Fuel: {game_objects.in_silence.Vehicle.need_fuelCount}");
                GUI.Label(new Rect(10f, 95f, 145f, 25f), $"Metal Scrap: {game_objects.in_silence.Vehicle.need_metalCount}");
                GUI.Label(new Rect(160f, 45f, 145f, 25f), $"Carkey: {game_objects.in_silence.Vehicle.need_KeyCount}");
                GUI.Label(new Rect(160f, 70f, 145f, 25f), $"Car Battery: {game_objects.in_silence.Vehicle.need_batteryCount}");
                
                GUI.Label(new Rect(10f, 133f, 145f, 25f), $"Armory Code: {Utils.GetArmoryKeyCode()}");
            }
            
            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void PlayerWindow(int windowID)
        {
            float sY = 20f;

            if (PhotonNetwork.CurrentRoom != null)
            {
                if (PhotonNetwork.CurrentRoom.Players.Count >= 1)
                {
                    foreach (Photon.Realtime.Player i in PhotonNetwork.CurrentRoom.Players.Values)
                    {
                        if (i.IsMasterClient)
                        {
                            GUI.Label(new Rect(10f, sY, 320f, 25f), $"{i.NickName} [Host]");
                        }
                        else
                        {
                            GUI.Label(new Rect(10f, sY, 200f, 25f), $"{i.NickName}");
                        }
                        
                        if (GUI.Button(new Rect(327f, sY, 107f, 25f), "Make Host"))
                        {
                            PhotonNetwork.SetMasterClient(i);
                        }
                        sY += 25f;
                    }
                }
            }
            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }

        public static void MainWindow(int windowID)
        {
            modules.UI.t_menu_esp = GUI.Toggle(new Rect(10f, 20f, 203f, 20f), modules.UI.esp_menu, "ESP Menu");
            if (modules.UI.t_menu_esp != modules.UI.esp_menu)
            {
                modules.UI.esp_menu = !modules.UI.esp_menu;
            }
            modules.UI.t_menu_player = GUI.Toggle(new Rect(10f, 45f, 203f, 20f), modules.UI.player_menu, "Player Menu");
            if (modules.UI.t_menu_player != modules.UI.player_menu)
            {
                modules.UI.player_menu = !modules.UI.player_menu;
            }
            modules.UI.t_menu_info = GUI.Toggle(new Rect(10f, 70f, 203f, 20f), modules.UI.gameinfo_menu, "Info Menu");
            if (modules.UI.t_menu_info != modules.UI.gameinfo_menu)
            {
                modules.UI.gameinfo_menu = !modules.UI.gameinfo_menu;
            }
            modules.UI.t_menu_control = GUI.Toggle(new Rect(10f, 95f, 203f, 20f), modules.UI.t_menucontrol, "Control Menu");
            if (modules.UI.t_menu_control != modules.UI.t_menucontrol)
            {
                modules.UI.t_menucontrol = !modules.UI.t_menucontrol;
            }
            modules.UI.toggleAimbot = GUI.Toggle(new Rect(10f, 120f, 203f, 20f), modules.UI.t_Aimbot, "Toggle Aimbot");
            if (modules.UI.toggleAimbot != modules.UI.t_Aimbot)
            {
                modules.UI.t_Aimbot = !modules.UI.t_Aimbot;
            }
            GUI.DragWindow(new Rect(0, 0, (float)Screen.width, (float)Screen.height));
        }
    }
}
