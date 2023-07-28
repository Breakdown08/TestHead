using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public abstract class BaseItem : MonoBehaviour
{
    [Header("Stat - Health Points")] public int healthPoints;
    [Header("Stat - Health Points")] public int attack;
    [Header("Stat - Health Points")] public int defence;
    [Header("Amount of all stats")] public int itemQuality;
    public int type;
    public int healthPointsMin;
    public int healthPointsMax;
    public int attackMin;
    public int attackMax;
    public int defenceMin;
    public int defenceMax;
    public ItemType itemType;

    private static System.Random random = new System.Random();

    Icon GetRandomIconFromList(List<Icon> list)
    {
        return list[random.Next(list.Count)];
    }
    void Start()
    {
        transform.GetComponent<Image>().enabled = false;
        SetCharacteristicsRange();
        healthPoints = System.Convert.ToInt32(UnityEngine.Random.Range(healthPointsMin, healthPointsMax));
        attack = System.Convert.ToInt32(UnityEngine.Random.Range(attackMin, attackMax));
        defence = System.Convert.ToInt32(UnityEngine.Random.Range(defenceMin, defenceMax));
        itemQuality = healthPoints + attack + defence;
        if (itemQuality >= 50)
        {
            transform.GetComponent<Image>().sprite = GetRandomIconFromList(Game.Instance.icons.Where(x => x.itemType == itemType).Where(x => x.isEpic).ToList()).source;
        }
        else
        {
            transform.GetComponent<Image>().sprite = GetRandomIconFromList(Game.Instance.icons.Where(x => x.itemType == itemType).ToList()).source;
        }
    }

    public virtual void SetCharacteristicsRange()
    {
        
    }

    void Update()
    {

    }
}
