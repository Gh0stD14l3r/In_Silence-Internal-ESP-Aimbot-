using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using SmartFPController;

namespace In_Silence.modules
{
    class ESP
    {
        private static Vector3 tbone_head, tbone_neck, tbone_spine1, tbone_spine2, tbone_spine3, tbone_spine4, tbone_hips;
        private static Vector3 tbone_legR, tbone_leg1R, tbone_leg2R, tbone_leg3R, tbone_leg4R, tbone_footR;
        private static Vector3 tbone_legL, tbone_leg1L, tbone_leg2L, tbone_leg3L, tbone_leg4L, tbone_footL;
        private static Vector3 tbone_tail1, tbone_tail2, tbone_tail3, tbone_tail4, tbone_tail5, tbone_tail6, tbone_tail7;
        private static Vector3 tbone_shoulderL, tbone_armL, tbone_elbowL, tbone_handL;
        private static Vector3 tbone_shoulderR, tbone_armR, tbone_elbowR, tbone_handR;


        public static void performESP()
        {
            if (modules.UI.t_ESPItem)
            {
                foreach (Item entity in Hacks.eItem) //keep
                {
                    
                    if (entity != null)
                    {
                        if (!entity.name.ToLower().Contains("fireworks") && !entity.name.ToLower().Contains("radio") && !entity.name.ToLower().Contains("trap"))
                        {
                            if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                            {
                                if (entity.name.ToLower().Contains("camuflage"))
                                {
                                    DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.green, entity.item_name.Replace("item_name_", "").Replace("camuflage", "camoflage"));
                                }
                                else
                                {
                                    switch (entity.item_name.Replace("item_name_", ""))
                                    {
                                        case string a when a.Contains("carkey"):
                                            if (game_objects.in_silence.Vehicle.need_KeyCount > 0)
                                            {
                                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.item_name.Replace("item_name_", ""));
                                            }
                                            break;
                                        case string b when b.Contains("wheel"):
                                            if (game_objects.in_silence.Vehicle.need_wheelCount > 0)
                                            {
                                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.item_name.Replace("item_name_", ""));
                                            }
                                            break;
                                        case string c when c.Contains("metalscrap"):
                                            if (game_objects.in_silence.Vehicle.need_metalCount > 0)
                                            {
                                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.item_name.Replace("item_name_", ""));
                                            }
                                            break;
                                        case string d when d.Contains("carbattery"):
                                            if (game_objects.in_silence.Vehicle.need_batteryCount > 0)
                                            {
                                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.item_name.Replace("item_name_", ""));
                                            }
                                            break;
                                        case string e when e.Contains("fuel"):
                                            if (game_objects.in_silence.Vehicle.need_fuelCount > 0)
                                            {
                                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.item_name.Replace("item_name_", ""));
                                            }
                                            break;
                                        default:
                                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.item_name.Replace("item_name_", ""));
                                            break;
                                    }
                                    
                                }
                            }
                        }

                    }
                }

                foreach (ArmoryDoor entity in Hacks.eArmoryDoor) //keep
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.yellow, "ArmoryDoor");
                        }
                    }
                }

                foreach (BearTrap entity in Hacks.eBearTrap)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.name.Replace("(Clone)", ""));
                        }
                    }
                }

                foreach (Rifle entity in Hacks.eRifle)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.name);
                        }
                    }
                }

                foreach (Stone entity in Hacks.eStone)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, "Stone: " + entity.name);
                        }
                    }
                }

                foreach (PuzzleButton entity in Hacks.ePuzzleButton) 
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.yellow, entity.name);
                        }
                    }
                }

                foreach (PuzzleCabin entity in Hacks.ePuzzleCabin)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.yellow, entity.name);
                        }
                    }
                }

                foreach (PuzzleKey entity in Hacks.ePuzzleKey)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.yellow, $"{entity.name} [{entity.puzzleCode}]");
                        }
                    }
                }

                foreach (PuzzleTablet entity in Hacks.ePuzzleTablet)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.yellow, entity.name);
                        }
                    }
                }
            }
            
            if (modules.UI.t_ESPAlertItem)
            {
                foreach (ActivableItem entity in Hacks.eActivableItem)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.red, entity.name.Replace("(Clone)", ""));
                            
                        }
                    }
                }

                foreach (Crow entity in Hacks.eCrow)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, "Crow");
                        }
                    }
                }

                foreach (CrowFlock entity in Hacks.eCrowFlock)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, "CrowFlock");
                        }
                    }
                }

                foreach (DogHouse entity in Hacks.eDogHouse)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.green, "DogHouse");
                        }
                    }
                }

                foreach (JackInBox entity in Hacks.eJackInBox)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.red, "JackInBox");
                        }
                    }
                }

                foreach (RabbitController entity in Hacks.eRabbitController)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.white, entity.name);
                        }
                    }
                }

                foreach (Toy entity in Hacks.eToy)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.red, "Toy");
                        }
                    }
                }
            }
            

            if (modules.UI.t_ESPPlayer)
            {

                foreach (SurvivorNetworking entity in Hacks.ePlayableCharacter)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f && Vector3.Distance(entity.transform.position, Hacks.MainCamera.transform.position) >= 1f && !entity.photonView.Owner.IsLocal)
                        {
                            
                            if (entity.playerState.isRat)
                            {
                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.GetComponentInChildren<PlayableCharacter>().transform.position), Color.yellow, $"Rat");
                            }
                            
                            if (entity.playerState.isSurvivor)
                            {
                                Transform[] entityBones = entity.GetComponentInChildren<PlayableCharacter>().GetComponentInChildren<SkinnedMeshRenderer>().bones;

                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.green, $"{entity.photonView.Owner.NickName} [{Math.Round(Vector3.Distance(entity.transform.position, Hacks.MainCamera.transform.position), 0)}]");

                                Vector3 tbone_head = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("head")).ToArray().First().position);
                                Vector3 tbone_neck = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("neck")).ToArray().First().position);
                                Vector3 tbone_spine1 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("spine_1")).ToArray().First().position);
                                Vector3 tbone_hips = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("hips")).ToArray().First().position);

                                Vector3 tbone_shoulderL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("shoulder.l")).ToArray().First().position);
                                Vector3 tbone_armL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("arm.l")).ToArray().First().position);
                                Vector3 tbone_elbowL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("elbow.l")).ToArray().First().position);
                                Vector3 tbone_handL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("hand.l")).ToArray().First().position);

                                Vector3 tbone_shoulderR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("shoulder.r")).ToArray().First().position);
                                Vector3 tbone_armR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("arm.r")).ToArray().First().position);
                                Vector3 tbone_elbowR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("elbow.r")).ToArray().First().position);
                                Vector3 tbone_handR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("hand.r")).ToArray().First().position);

                                Vector3 tbone_legR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("knee.r")).ToArray().First().position);
                                Vector3 tbone_footR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("foot.r")).ToArray().First().position);

                                Vector3 tbone_legL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("knee.l")).ToArray().First().position);
                                Vector3 tbone_footL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("foot.l")).ToArray().First().position);
                                

                                DrawBoneLine(tbone_head, tbone_neck, Color.green);
                                DrawBoneLine(tbone_neck, tbone_hips, Color.green);
                                
                                DrawBoneLine(tbone_hips, tbone_legR, Color.green);
                                DrawBoneLine(tbone_legR, tbone_footR, Color.green);

                                DrawBoneLine(tbone_hips, tbone_legL, Color.green);
                                DrawBoneLine(tbone_legL, tbone_footL, Color.green);

                                DrawBoneLine(tbone_neck, tbone_shoulderL, Color.green);
                                DrawBoneLine(tbone_shoulderL, tbone_armL, Color.green);
                                DrawBoneLine(tbone_armL, tbone_elbowL, Color.green);
                                DrawBoneLine(tbone_elbowL, tbone_handL, Color.green);

                                DrawBoneLine(tbone_neck, tbone_shoulderR, Color.green);
                                DrawBoneLine(tbone_shoulderR, tbone_armR, Color.green);
                                DrawBoneLine(tbone_armR, tbone_elbowR, Color.green);
                                DrawBoneLine(tbone_elbowR, tbone_handR, Color.green);
                                
                            }

                        }
                    }
                    
                }

                foreach (PlayableCharacter entity in Hacks.eBodyPlayer)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f && Vector3.Distance(entity.transform.position, Hacks.MainCamera.transform.position) >= 1f)
                        {
                            if (entity.characterType == PlayableCharacter.CharacterType.Rat)
                            {
                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.GetComponentInChildren<PlayableCharacter>().transform.position), Color.yellow, "Rat");
                            }
                            
                            if (entity.characterType == PlayableCharacter.CharacterType.Creature)
                            {
                                Transform[] entityBones = entity.GetComponentInChildren<PlayableCharacter>().GetComponentInChildren<SkinnedMeshRenderer>().bones;

                                DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.GetComponentInChildren<PlayableCharacter>().transform.position), Color.cyan, "Creature");
                                
                                Vector3 tbone_head = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("head")).ToArray().First().position);
                                Vector3 tbone_neck = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("neck")).ToArray().First().position);
                                Vector3 tbone_spine1 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("spine_1")).ToArray().First().position);
                                Vector3 tbone_hips = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("hips")).ToArray().First().position);

                                Vector3 tbone_shoulderL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("shoulder.l")).ToArray().First().position);
                                Vector3 tbone_armL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("arm.l")).ToArray().First().position);
                                Vector3 tbone_elbowL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("elbow.l")).ToArray().First().position);
                                Vector3 tbone_handL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("hand.l")).ToArray().First().position);

                                Vector3 tbone_shoulderR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("shoulder.r")).ToArray().First().position);
                                Vector3 tbone_armR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("arm.r")).ToArray().First().position);
                                Vector3 tbone_elbowR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("elbow.r")).ToArray().First().position);
                                Vector3 tbone_handR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("hand.r")).ToArray().First().position);

                                Vector3 tbone_legR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg.r")).ToArray().First().position);
                                Vector3 tbone_leg1R = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg_1.r")).ToArray().First().position);
                                Vector3 tbone_leg2R = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg_2.r")).ToArray().First().position);
                                Vector3 tbone_leg3R = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg_3.r")).ToArray().First().position);
                                Vector3 tbone_leg4R = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg_4.r")).ToArray().First().position);
                                Vector3 tbone_footR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("foot.r")).ToArray().First().position);

                                Vector3 tbone_legL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg.l")).ToArray().First().position);
                                Vector3 tbone_leg1L = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg_1.l")).ToArray().First().position);
                                Vector3 tbone_leg2L = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg_2.l")).ToArray().First().position);
                                Vector3 tbone_leg3L = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg_3.l")).ToArray().First().position);
                                Vector3 tbone_leg4L = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("leg_4.l")).ToArray().First().position);
                                Vector3 tbone_footL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("foot.l")).ToArray().First().position);

                                Vector3 tbone_tail1 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("tail_1")).ToArray().First().position);
                                Vector3 tbone_tail2 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("tail_2")).ToArray().First().position);
                                Vector3 tbone_tail3 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("tail_3")).ToArray().First().position);
                                Vector3 tbone_tail4 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("tail_4")).ToArray().First().position);
                                Vector3 tbone_tail5 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("tail_5")).ToArray().First().position);
                                Vector3 tbone_tail6 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("tail_6")).ToArray().First().position);
                                Vector3 tbone_tail7 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.ToLower().Contains("tail_7")).ToArray().First().position);

                                DrawBoneLine(tbone_head, tbone_neck, Color.magenta);
                                DrawBoneLine(tbone_neck, tbone_spine1, Color.magenta);
                                DrawBoneLine(tbone_spine1, tbone_hips, Color.magenta);

                                DrawBoneLine(tbone_hips, tbone_legR, Color.magenta);
                                DrawBoneLine(tbone_legR, tbone_leg1R, Color.magenta);
                                DrawBoneLine(tbone_leg1R, tbone_leg2R, Color.magenta);
                                DrawBoneLine(tbone_leg2R, tbone_leg3R, Color.magenta);
                                DrawBoneLine(tbone_leg3R, tbone_leg4R, Color.magenta);
                                DrawBoneLine(tbone_leg4R, tbone_footR, Color.magenta);

                                DrawBoneLine(tbone_hips, tbone_legL, Color.magenta);
                                DrawBoneLine(tbone_legL, tbone_leg1L, Color.magenta);
                                DrawBoneLine(tbone_leg1L, tbone_leg2L, Color.magenta);
                                DrawBoneLine(tbone_leg2L, tbone_leg3L, Color.magenta);
                                DrawBoneLine(tbone_leg3L, tbone_leg4L, Color.magenta);
                                DrawBoneLine(tbone_leg4L, tbone_footL, Color.magenta);

                                DrawBoneLine(tbone_neck, tbone_shoulderL, Color.magenta);
                                DrawBoneLine(tbone_shoulderL, tbone_armL, Color.magenta);
                                DrawBoneLine(tbone_armL, tbone_elbowL, Color.magenta);
                                DrawBoneLine(tbone_elbowL, tbone_handL, Color.magenta);

                                DrawBoneLine(tbone_neck, tbone_shoulderR, Color.magenta);
                                DrawBoneLine(tbone_shoulderR, tbone_armR, Color.magenta);
                                DrawBoneLine(tbone_armR, tbone_elbowR, Color.magenta);
                                DrawBoneLine(tbone_elbowR, tbone_handR, Color.magenta);

                                DrawBoneLine(tbone_hips, tbone_tail1, Color.magenta);
                                DrawBoneLine(tbone_tail1, tbone_tail2, Color.magenta);
                                DrawBoneLine(tbone_tail2, tbone_tail3, Color.magenta);
                                DrawBoneLine(tbone_tail3, tbone_tail4, Color.magenta);
                                DrawBoneLine(tbone_tail4, tbone_tail5, Color.magenta);
                                DrawBoneLine(tbone_tail5, tbone_tail6, Color.magenta);
                                DrawBoneLine(tbone_tail6, tbone_tail7, Color.magenta);
                                
                            }
                        }
                    }
                }
            }
            
            if (modules.UI.t_ESPVehicle)
            {
                foreach (TruckPart entity in Hacks.eTruckPart)
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.cyan, entity.name);
                        }
                    }
                }
            }

            if (modules.UI.t_ESPCreature)
            {
                foreach (CreatureAIManager entity in Hacks.eCreature) //keep
                {
                    if (entity != null)
                    {
                        if (Hacks.MainCamera.WorldToScreenPoint(entity.transform.position).z > 0f)
                        {
                            DrawText(Hacks.MainCamera.WorldToScreenPoint(entity.transform.position), Color.magenta, $"Creature: [{Math.Round(Vector3.Distance(entity.transform.position, Hacks.MainCamera.transform.position),0)}]");

                            /*Transform[] entityBones = entity.GetComponentInChildren<SkinnedMeshRenderer>().bones;

                            Vector3 tbone_head = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("head")).ToArray().First().position);
                            Vector3 tbone_neck = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("neck")).ToArray().First().position);
                            Vector3 tbone_spine1 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("spine_1")).ToArray().First().position);
                            Vector3 tbone_hips = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("hips")).ToArray().First().position);

                            Vector3 tbone_shoulderL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("shoulder.L")).ToArray().First().position);
                            Vector3 tbone_armL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("arm.L")).ToArray().First().position);
                            Vector3 tbone_elbowL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("elbow.L")).ToArray().First().position);
                            Vector3 tbone_handL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("hand.L")).ToArray().First().position);

                            Vector3 tbone_shoulderR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("shoulder.R")).ToArray().First().position);
                            Vector3 tbone_armR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("arm.R")).ToArray().First().position);
                            Vector3 tbone_elbowR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("elbow.R")).ToArray().First().position);
                            Vector3 tbone_handR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("hand.R")).ToArray().First().position);

                            Vector3 tbone_legR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg.R")).ToArray().First().position);
                            Vector3 tbone_leg1R = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg_1.R")).ToArray().First().position);
                            Vector3 tbone_leg2R = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg_2.R")).ToArray().First().position);
                            Vector3 tbone_leg3R = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg_3.R")).ToArray().First().position);
                            Vector3 tbone_leg4R = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg_4.R")).ToArray().First().position);
                            Vector3 tbone_footR = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("foot.R")).ToArray().First().position);

                            Vector3 tbone_legL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg.L")).ToArray().First().position);
                            Vector3 tbone_leg1L = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg_1.L")).ToArray().First().position);
                            Vector3 tbone_leg2L = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg_2.L")).ToArray().First().position);
                            Vector3 tbone_leg3L = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg_3.L")).ToArray().First().position);
                            Vector3 tbone_leg4L = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("leg_4.L")).ToArray().First().position);
                            Vector3 tbone_footL = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("foot.L")).ToArray().First().position);

                            Vector3 tbone_tail1 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("tail_1")).ToArray().First().position);
                            Vector3 tbone_tail2 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("tail_2")).ToArray().First().position);
                            Vector3 tbone_tail3 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("tail_3")).ToArray().First().position);
                            Vector3 tbone_tail4 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("tail_4")).ToArray().First().position);
                            Vector3 tbone_tail5 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("tail_5")).ToArray().First().position);
                            Vector3 tbone_tail6 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("tail_6")).ToArray().First().position);
                            Vector3 tbone_tail7 = Camera.current.WorldToScreenPoint(entityBones.Where<Transform>(b => b.name.Contains("tail_7")).ToArray().First().position);

                            DrawBoneLine(tbone_head, tbone_neck, Color.magenta);
                            DrawBoneLine(tbone_neck, tbone_spine1, Color.magenta);
                            DrawBoneLine(tbone_spine1, tbone_hips, Color.magenta);

                            DrawBoneLine(tbone_hips, tbone_legR, Color.magenta);
                            DrawBoneLine(tbone_legR, tbone_leg1R, Color.magenta);
                            DrawBoneLine(tbone_leg1R, tbone_leg2R, Color.magenta);
                            DrawBoneLine(tbone_leg2R, tbone_leg3R, Color.magenta);
                            DrawBoneLine(tbone_leg3R, tbone_leg4R, Color.magenta);
                            DrawBoneLine(tbone_leg4R, tbone_footR, Color.magenta);

                            DrawBoneLine(tbone_hips, tbone_legL, Color.magenta);
                            DrawBoneLine(tbone_legL, tbone_leg1L, Color.magenta);
                            DrawBoneLine(tbone_leg1L, tbone_leg2L, Color.magenta);
                            DrawBoneLine(tbone_leg2L, tbone_leg3L, Color.magenta);
                            DrawBoneLine(tbone_leg3L, tbone_leg4L, Color.magenta);
                            DrawBoneLine(tbone_leg4L, tbone_footL, Color.magenta);

                            DrawBoneLine(tbone_neck, tbone_shoulderL, Color.magenta);
                            DrawBoneLine(tbone_shoulderL, tbone_armL, Color.magenta);
                            DrawBoneLine(tbone_armL, tbone_elbowL, Color.magenta);
                            DrawBoneLine(tbone_elbowL, tbone_handL, Color.magenta);

                            DrawBoneLine(tbone_neck, tbone_shoulderR, Color.magenta);
                            DrawBoneLine(tbone_shoulderR, tbone_armR, Color.magenta);
                            DrawBoneLine(tbone_armR, tbone_elbowR, Color.magenta);
                            DrawBoneLine(tbone_elbowR, tbone_handR, Color.magenta);

                            DrawBoneLine(tbone_hips, tbone_tail1, Color.magenta);
                            DrawBoneLine(tbone_tail1, tbone_tail2, Color.magenta);
                            DrawBoneLine(tbone_tail2, tbone_tail3, Color.magenta);
                            DrawBoneLine(tbone_tail3, tbone_tail4, Color.magenta);
                            DrawBoneLine(tbone_tail4, tbone_tail5, Color.magenta);
                            DrawBoneLine(tbone_tail5, tbone_tail6, Color.magenta);
                            DrawBoneLine(tbone_tail6, tbone_tail7, Color.magenta);*/

                        }
                    }
                }
            }
        }


        public static void DrawText(Vector3 objVector, Color objColor, String name)
        {
            Render.DrawString(new Vector2(objVector.x, (float)Screen.height - objVector.y), $"{name}", objColor);
        }

        public static void DrawBoneLine(Vector3 w2s_objectStart, Vector3 w2s_objectFinish, Color color)
        {
            if (w2s_objectStart != null && w2s_objectFinish != null)
            {
                Render.DrawLine(new Vector2(w2s_objectStart.x, (float)Screen.height - w2s_objectStart.y), new Vector2(w2s_objectFinish.x, (float)Screen.height - w2s_objectFinish.y), color, 1f);
            }
        }
    }
}
