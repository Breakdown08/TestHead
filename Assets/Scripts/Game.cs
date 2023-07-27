using UnityEngine;
using System.Collections.Generic;

public class Game : MonoBehaviour
{
    public static Game Instance { get; private set; }
    [Header("Объект игрока")] public GameObject player;
    [Header("Префабы предметов инвентаря")] public List<GameObject> itemPrefabList;
    [Header("Коллекция иконок")] public Icon[] icons;
    private bool canSpawn = true;

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

    public void SpawnItem()
    {
        Debug.Log("asdasdasdasddas");
        GameObject itemInstance;
        int itemIndex = System.Convert.ToInt32(UnityEngine.Random.Range(0, itemPrefabList.Count));
        itemInstance = Instantiate(itemPrefabList[itemIndex]) as GameObject;
        player.GetComponent<Player>().GetItem(itemInstance, itemInstance.GetComponent<BaseItem>().itemType);
    }

    public void Exit()
    {
        Application.Quit();
    }
}