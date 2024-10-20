using System;

using UnityEngine;

namespace LiarsBarEnhance.Components;

public class FzHint : MonoBehaviour
{
    public static bool isKnown = false;

    private readonly float displayTime = 30f;
    private readonly float hideTime = 180f;

    private float lastHideTime;

    private void Awake()
    {
        if (Manager.Instance.Players.Count != 4 || isKnown)
            Destroy(this);
        lastHideTime = Time.time;
    }

    private void OnGUI()
    {
        if (Time.time - lastHideTime < hideTime)
            return;

        var textStyle = new GUIStyle()
        {
            fontSize = 24,
            wordWrap = true,
            normal = new GUIStyleState()
            {
                textColor = Color.green
            }
        };
        GUI.Label(new Rect(0f, 0f, Screen.width, 200f), "此插件是!免费且开源!在github上的，如果你是在其他途径下载的插件，则!可能!是被!恶意修改!过的，建议前往GitHub下载。\n地址为https://github.com/dogdie233/LiarsBarEnhance", textStyle);
        if (GUI.Button(new Rect(0f, 100f, Screen.width / 2f, 100f), "好的我知道了，不再显示（按ESC之后点我）"))
        {
            isKnown = true;
            Destroy(this);
        }

        if (Time.time - lastHideTime > hideTime + displayTime)
            lastHideTime = Time.time;
    }
}