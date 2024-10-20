using HarmonyLib;

using UnityEngine;

namespace LiarsBarEnhance.Features;

[HarmonyPatch]
public class BigMouthPatch
{
    [HarmonyPatch(typeof(CharController), nameof(CharController.Update))]
    [HarmonyPostfix]
    public static void UpdatePostfix(CharController __instance)
    {
        if (!__instance.isOwned)
            return;

        var mouth = __instance.HeadPivot.Find("Base HumanHead/Mouth");
        if (Input.GetKey(KeyCode.O))
            mouth.transform.localPosition = new Vector3(0.5f, 0.2f, 0f);
        if (Input.GetKeyUp(KeyCode.O))
            mouth.transform.localPosition = Vector3.zero;
    }
}