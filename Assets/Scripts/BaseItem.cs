using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class BaseItem : MonoBehaviour
{
    [Header("Характеристика - здоровье")] public int healthPoints;
    [Header("Характеристика - атака")] public int attack;
    [Header("Характеристика - защита")] public int defence;
    [Header("Суммарный показатель характеристик предмета")] public int itemScore;
    [Header("Иконка предмета")] public Image icon;
    public int type;
    public int healthPointsMin;
    public int healthPointsMax;
    public int attackMin;
    public int attackMax;
    public int defenceMin;
    public int defenceMax;
    public ItemType itemType;

    Icon GetRandomIconFromList(List<Icon> list)
    {
        var random = new System.Random();
        return list[random.Next(list.Count)];
    }
    void Start()
    {
        SetCharacteristicsRange();
        healthPoints = System.Convert.ToInt32(UnityEngine.Random.Range(healthPointsMin, healthPointsMax));
        attack = System.Convert.ToInt32(UnityEngine.Random.Range(attackMin, attackMax));
        defence = System.Convert.ToInt32(UnityEngine.Random.Range(defenceMin, defenceMax));
        itemScore = healthPoints + attack + defence;
        if (itemScore >= 50)
        {
            GetRandomIconFromList(Game.Instance.icons.Where(x => x.itemType == itemType).Where(x => x.isEpic).ToList());
        }
        else
        {
            GetRandomIconFromList(Game.Instance.icons.Where(x => x.itemType == itemType).ToList());
        }
    }

    public virtual void SetCharacteristicsRange()
    {
        
    }
}
