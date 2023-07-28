using UnityEngine;
using System.Collections.Generic;

public class Game : MonoBehaviour
{
    public static Game Instance { get; private set; }
    [Header("Player object")] public GameObject player;
    [Header("Inventory item prefabs")] public List<GameObject> itemPrefabList;
    [Header("Icons collection")] public Icon[] icons;
    public GameObject chest;
    private bool canSpawn = true;
    private static System.Random random = new System.Random();
    public int money;
    public int gearScore = 0;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        
    }


    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }

    public GameObject GetCurrentItem(ItemType itemType)
    {
        Transform parent = player.GetComponent<Player>().bag.transform;
        if (parent.childCount > 0)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform childTransform = parent.GetChild(i);
                if (childTransform.GetComponent<BaseItem>().itemType == itemType)
                {
                    //Debug.Log("Child " + i + " name: " + childTransform.name);
                    return childTransform.gameObject;
                }
            }   
        }
        return null;
    }

    public void CalculateGearScore()
    {
        gearScore = 0;
        Transform parent = player.GetComponent<Player>().bag.transform;
        if (parent.childCount > 0)
        {
            for (int i = 0; i < parent.childCount; i++)
            {
                Transform childTransform = parent.GetChild(i);
                int value = childTransform.GetComponent<BaseItem>().itemQuality;
                gearScore += value;
            }   
        }
        Interface.Instance.UpdateGearScore();
    }

    public void SpawnItem()
    {
        GameObject itemInstance;
        int itemIndex = System.Convert.ToInt32(random.Next(0, itemPrefabList.Count));
        itemInstance = Instantiate(itemPrefabList[itemIndex]) as GameObject;
        itemInstance.transform.SetParent(chest.transform, false);
        ItemType itemType = itemInstance.GetComponent<BaseItem>().itemType;
        Interface.Instance.SetCurrentItem(GetCurrentItem(itemType));
        Interface.Instance.SetNewItem(itemInstance);
    }

    public void EqipItem()
    {
        ItemType itemType = chest.transform.GetChild(0).GetComponent<BaseItem>().itemType;
        DropItem(GetCurrentItem(itemType));
        chest.transform.GetChild(0).SetParent(player.GetComponent<Player>().bag.transform, false);
        player.GetComponent<Player>().GetItem(itemType);
        CalculateGearScore();
    }

    public void DropItem(GameObject item)
    {
        if (item)
        {
            money += item.GetComponent<BaseItem>().itemQuality / 2;
            Destroy(item);
            Interface.Instance.UpdateMoney();
        }
    }

    public void DropItem()
    {
        money += chest.transform.GetChild(0).GetComponent<BaseItem>().itemQuality / 2;
        Destroy(chest.transform.GetChild(0).gameObject);
        Interface.Instance.UpdateMoney();
    }

    public void Exit()
    {
        Application.Quit();
    }
}