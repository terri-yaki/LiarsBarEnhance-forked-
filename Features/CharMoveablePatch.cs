using HarmonyLib;

using LiarsBarEnhance.Components;

using UnityEngine;

namespace LiarsBarEnhance.Features;

[HarmonyPatch]
public class CharMoveablePatch
{
    [HarmonyPatch(typeof(CharController), nameof(CharController.Start))]
    [HarmonyPostfix]
    public static void StartPostfix(CharController __instance)
    {
        __instance.gameObject.AddComponent<FpController>();
        Debug.Log($"{nameof(CharMoveablePatch)}: {nameof(FpController)} added to {nameof(CharController)}");
    }

    [HarmonyPatch(typeof(CharController), "RotateInFrame")]
    [HarmonyPrefix]
    public static void RotateInFramePrefix(CharController __instance, ref bool __runOriginal)
    {
        var isBodyRotating = Input.GetMouseButton(1);
        __runOriginal = !isBodyRotating;
        if (!isBodyRotating)
            return;

        var sensivty = PlayerPrefs.GetFloat("MouseSensivity", 50f);
        __instance.transform.localEulerAngles += Input.GetAxis("Mouse X") * Time.deltaTime * sensivty * Vector3.up;
        __instance.transform.localEulerAngles += -Input.GetAxis("Mouse Y") * Time.deltaTime * sensivty * Vector3.left;
    }
}