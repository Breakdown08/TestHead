using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Profiling;
using System;

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
        GameObject itemInstance;
        int itemIndex = System.Convert.ToInt32(UnityEngine.Random.Range(0, itemPrefabList.Count));
        if (canSpawn)
        {
            itemInstance = Instantiate(itemPrefabList[itemIndex]) as GameObject;
            
        }
        else
        {
            SpawnItem();
        }
    }

    IEnumerator SpawnItemtt()
    {
        while (true)
        {
            /*
            if (isGameOver == false && Time.timeScale == 1)
            {
                GameObject enemyInstance;
                int spawnPoint = System.Convert.ToInt32(UnityEngine.Random.Range(0, spawnPoints.transform.childCount));
                int enemyIndex = System.Convert.ToInt32(UnityEngine.Random.Range(0, enemyList.Count));
                int waitTime = System.Convert.ToInt32(UnityEngine.Random.Range(0, 7));
                yield return new WaitForSeconds(waitTime + spawnSpeed);
                if (canSpawn)
                {
                    enemyInstance = Instantiate(enemyList[enemyIndex], spawnPoints.transform.GetChild(spawnPoint).transform.position, Quaternion.Euler(0f, 0f, 0f)) as GameObject;
                    enemyInstance.transform.SetParent(aliveEnemyStorage.transform, false);
                    enemyInstance.transform.position = spawnPoints.transform.GetChild(spawnPoint).transform.position;
                }
                StartCoroutine(SpawnEnemy());
            }
            */
            yield break;
        }
    }


    public void Restart()
    {
        /*
        if (Interface.Instance.continueGameText.activeSelf == false)
        {
            player.GetComponent<Player>().SetDefaultPosition();
            Time.timeScale = 1;
            isFirstEntryGame = false;
            
            if (GetEnemyCount() > 0)
            {
                foreach (Transform child in aliveEnemyStorage.transform) 
                {
                    Destroy(child.gameObject);
                }
            }
            isGameOver = false;
            StartCoroutine(SpawnEnemy());
        }
        else
        {

        }
        Interface.Instance.OpenGame();
        */
    }

    public void Exit()
    {
        Application.Quit();
    }
}