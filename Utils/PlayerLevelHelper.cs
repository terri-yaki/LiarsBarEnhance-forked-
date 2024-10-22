using System;
using System.Collections.Generic;

using HarmonyLib;

namespace LiarsBarEnhance.Utils;

public static class PlayerLevelHelper
{
    private static readonly List<int> xpNeededList = [];
    private static readonly Action calculateNeeds;

    static PlayerLevelHelper()
    {
        var xpSave = DatabaseManager.instance.XP;
        var dbManager = DatabaseManager.instance;
        calculateNeeds = (Action)AccessTools.Method(typeof(DatabaseManager), "CalculateNeeds")
            .CreateDelegate(typeof(Action), dbManager);

        xpNeededList.Add(0);
        SetXp(0);
        calculateNeeds();
        Plugin.Logger.LogDebug($"[{nameof(PlayerLevelHelper)}] Level 0 ({(DatabaseManager.Levels)0}) needs {xpNeededList[0]} XP");
        while (dbManager.needs != 0)
        {
            xpNeededList.Add(xpNeededList[^1] + dbManager.needs);
            Plugin.Logger.LogDebug($"[{nameof(PlayerLevelHelper)}] Level {xpNeededList.Count - 1} ({(DatabaseManager.Levels)(xpNeededList.Count - 1)}) needs {xpNeededList[^1]} XP");
            SetXp(xpNeededList[^1]);
            calculateNeeds();
        }

        SetXp(xpSave);
        calculateNeeds();
    }

    public static void SetXp(int xp)
        => FastMemberAccessor<DatabaseManager, int>.Set(DatabaseManager.instance, "xp", xp);

    public static void SetLevel(DatabaseManager.Levels level, int xpMore = 0)
        => SetXp(xpNeededList[(int)level] + xpMore);

    public static void CalculateNeeds()
        => calculateNeeds();

    public static int GetNeedXp(DatabaseManager.Levels level)
        => xpNeededList[(int)level];
}