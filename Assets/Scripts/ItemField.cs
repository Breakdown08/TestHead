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

    public void ActivatePositiveIndicator()
    {
        indicator.text = "↑";
        indicator.color = new Color(0, 255, 15);
    }

    public void ActivateNegativeIndicator()
    {
        indicator.text = "↓";
        indicator.color = new Color(255, 63, 15);
    }

    public void ClearIndicator()
    {
        indicator.text = "";
    }
}
