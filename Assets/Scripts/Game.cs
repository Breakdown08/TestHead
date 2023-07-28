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
                    Debug.Log("Child " + i + " name: " + childTransform.name);
                    return childTransform.gameObject;
                }
            }   
        }
        return null;
    }

    public void SpawnItem()
    {
        GameObject itemInstance;
        int itemIndex = System.Convert.ToInt32(random.Next(0, itemPrefabList.Count));
        itemInstance = Instantiate(itemPrefabList[itemIndex]) as GameObject;
        itemInstance.transform.SetParent(chest.transform, false);
        ItemType itemType = itemInstance.GetComponent<BaseItem>().itemType;
        Interface.Instance.SetNewItem(itemInstance);
        Interface.Instance.SetCurrentItem(GetCurrentItem(itemType));
    }

    public void EqipItem()
    {
        ItemType itemType = chest.transform.GetChild(0).GetComponent<BaseItem>().itemType;
        chest.transform.GetChild(0).SetParent(player.GetComponent<Player>().bag.transform, false);
        player.GetComponent<Player>().GetItem(itemType);
    }

    public void Exit()
    {
        Application.Quit();
    }
}