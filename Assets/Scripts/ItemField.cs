using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemField : MonoBehaviour
{
    public TMP_Text title;
    public TMP_Text indicator;

    public void SetText(string text)
    {
        title.text = text;
    }

    void Start()
    {
        indicator.overrideColorTags = true;
    }

    public void ActivatePositiveIndicator()
    {
        indicator.text = "↑";
        indicator.color = new Color(0.0f, 0.5f, 0.0f);
    }

    public void ActivateNegativeIndicator()
    {
        indicator.text = "↓";
        indicator.color = new Color(0.75f, 0.18f, 0.05f, 1f);
    }

    public void ClearIndicator()
    {
        indicator.text = "";
    }
}
