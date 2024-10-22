using HarmonyLib;
using UnityEngine;

namespace LiarsBarEnhance.Features;
    [HarmonyPatch]
    public class XP
    {
        [HarmonyPatch(typeof(DatabaseManager), "Update")]
        [HarmonyPostfix]
        public static void DatabaseManager_Modify(DatabaseManager __instance)
        {
            if (Input.GetKeyDown(KeyCode.F1)){
                Traverse.Create(__instance).Field("xp").SetValue(999999);
            }
        }
    }
