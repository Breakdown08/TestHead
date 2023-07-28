using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class Interface : MonoBehaviour
{
    public GameObject newItem;
    public GameObject currentItem;
    public GameObject popup;
    public TMP_Text gearScore;
    public TMP_Text money;
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
            Debug.Log("есть похожий");
            currentItem.GetComponent<ItemInfo>().SetItem(item, true);
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
        Game.Instance.DropItem();
        ClosePopup();
    }

    public void UpdateGearScore()
    {
        gearScore.text = "Gear Score: " + Game.Instance.gearScore.ToString();
    }

    public void UpdateMoney()
    {
        money.text = "Money: " + Game.Instance.money.ToString();
    }

    public void Update()
    {

    }
}
