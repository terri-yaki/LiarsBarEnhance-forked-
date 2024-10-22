using HarmonyLib;
using UnityEngine;

namespace LiarsBarEnhance.Features;
    [HarmonyPatch]
    public class XP
    {
        [HarmonyPatch(typeof(DatabaseManager), "Start")]
        [HarmonyPostfix]
        public static void DatabaseManager_Modify(DatabaseManager __instance)
        {
            Traverse.Create(__instance).Field("xp").SetValue(999999);
        }
    }
