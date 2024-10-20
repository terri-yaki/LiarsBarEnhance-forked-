using BepInEx;
using BepInEx.Logging;

using HarmonyLib;

using LiarsBarEnhance.Features;

namespace LiarsBarEnhance;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;

    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;

        Harmony.CreateAndPatchAll(typeof(RemoveHeadRotationlimitPatch), nameof(RemoveHeadRotationlimitPatch));
        Harmony.CreateAndPatchAll(typeof(CrazyShakeHeadPatch), nameof(CrazyShakeHeadPatch));
        Harmony.CreateAndPatchAll(typeof(ChatProPatch), nameof(ChatProPatch));
        Harmony.CreateAndPatchAll(typeof(CharMoveablePatch), nameof(CharMoveablePatch));
        Harmony.CreateAndPatchAll(typeof(BigMouthPatch), nameof(BigMouthPatch));
        Harmony.CreateAndPatchAll(typeof(ChineseNameFixPatch), nameof(ChineseNameFixPatch));
        Harmony.CreateAndPatchAll(typeof(RemoveNameLengthLimitPatch), nameof(RemoveNameLengthLimitPatch));

        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
    }
}
