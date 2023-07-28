using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemInfo : MonoBehaviour
{
    private GameObject item;
    public ItemField defence;
    public ItemField healthPoints;
    public ItemField attack;
    public ItemField itemQuality;
    public Image icon;
    void Start()
    {
        
    }

    public void MergeField(int currentValue, int newValue, ItemField itemField)
    {
        if (currentValue > newValue)
        {
            itemField.ActivatePositiveIndicator();
        }
        if (currentValue > newValue)
        {
            itemField.ActivateNegativeIndicator();
        }
        if (currentValue == newValue)
        {
            itemField.ClearIndicator();
        }
    }

    public IEnumerator UpdateStats()
    {
        yield return new WaitForEndOfFrame();
        defence.SetText("Defence: " + item.GetComponent<BaseItem>().defence.ToString());
        healthPoints.SetText("Health Points: " + item.GetComponent<BaseItem>().healthPoints.ToString());
        attack.SetText("Attack: " + item.GetComponent<BaseItem>().attack.ToString());
        itemQuality.SetText("Quality: " + item.GetComponent<BaseItem>().itemQuality.ToString());
        icon.sprite = item.transform.GetComponent<Image>().sprite;

        GameObject currentItem = Game.Instance.GetCurrentItem(item.GetComponent<BaseItem>().itemType);
        if (currentItem)
        {
            MergeField(currentItem.GetComponent<BaseItem>().healthPoints, item.GetComponent<BaseItem>().healthPoints, healthPoints);
            MergeField(currentItem.GetComponent<BaseItem>().defence, item.GetComponent<BaseItem>().defence, defence);
            MergeField(currentItem.GetComponent<BaseItem>().attack, item.GetComponent<BaseItem>().attack, attack);
            MergeField(currentItem.GetComponent<BaseItem>().itemQuality, item.GetComponent<BaseItem>().itemQuality, itemQuality);
        }
    }

    void Update()
    {
        
    }

    public void SetItem(GameObject newItem)
    {
        item = newItem;
        StartCoroutine(UpdateStats());
    }
}
