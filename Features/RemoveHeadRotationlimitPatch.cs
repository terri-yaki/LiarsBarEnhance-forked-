using HarmonyLib;

namespace LiarsBarEnhance.Features;

[HarmonyPatch]
public class RemoveHeadRotationlimitPatch
{
    [HarmonyPatch(typeof(CharController), "ClampAngle")]
    [HarmonyPrefix]
    public static void ClampAnglePrefix(float lfAngle, ref float __result, ref bool __runOriginal)
    {
        __runOriginal = false;
        if (lfAngle < -360.0)
            lfAngle += 360f;
        if (lfAngle > 360.0)
            lfAngle -= 360f;
        __result = lfAngle;
    }
}