using HarmonyLib;

using LiarsBarEnhance.Components;

namespace LiarsBarEnhance.Features;

[HarmonyPatch]
public class FzHintPatch
{
    [HarmonyPatch(typeof(CharController), nameof(CharController.Start))]
    [HarmonyPostfix]
    public static void StartPostfix(CharController __instance)
    {
        if (!__instance.isOwned)
            return;

        __instance.gameObject.AddComponentIfNotExist<FzHint>();
    }
}