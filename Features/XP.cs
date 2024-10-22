using HarmonyLib;
using UnityEngine;

namespace LiarsBarEnhance.Features;
    [HarmonyPatch]
    public class XP
    {
        [HarmonyPatch(typeof(DatabaseManager), "Start")]
        [HarmonyPostfix]
        public static void BlorfGamePlay_Look(DatabaseManager __instance)
        {
            Traverse.Create(__instance).Field("xp").SetValue(999999);
            int wins = Traverse.Create(__instance).Field("Wins").GetValue<int>();
            Debug.Log($"{wins}");
        }
    }
