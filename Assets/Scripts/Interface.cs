using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Interface : MonoBehaviour
{
    public GameObject newItem;
    public GameObject currentItem;
    public GameObject popup;
    public static Interface Instance { get; private set; } // Паттерн синглтон

    private void Awake()
    {
        Instance = this;
    }


    public void ActivatePopup()
    {
        popup.SetActive(true);
    }

    public void ClosePopup()
    {
        popup.SetActive(false);
    }

    public void SetCurrentItem(GameObject item)
    {
        if (item)
        {
            currentItem.GetComponent<ItemInfo>().SetItem(item);
        }
    }

    public void SetNewItem(GameObject item)
    {
        newItem.GetComponent<ItemInfo>().SetItem(item);
    }

    public void EqipItem()
    {
        Game.Instance.EqipItem();
        ClosePopup();
    }

    public void DropItem()
    {
        Game.Instance.EqipItem();
        ClosePopup();
    }
}
